using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Areas.Identity.Data;
using PHCApplication.Data;
using PHCApplication.Models;
using System.Security.Claims;

namespace PHCApplication.Controllers
{
    public class ReminderController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        

        public ReminderController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //    var pHCApplicationDbContext = _context.Reminder.Include(b => b.ApplicationUser);
            //    return View(await pHCApplicationDbContext.ToListAsync());

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                // Handle the case where the user's ID is not found
                return NotFound();
            }

            // Retrieve all upcoming reminders for the user
            var upcomingReminders = await _context.Reminder
                .Include(r => r.ApplicationUser) // Include ApplicationUser for accessing user information
                .Where(r => r.ApplicationUser.Id == userId && r.ReminderDate > DateTime.Now)
                .ToListAsync();

            return View(upcomingReminders);


        }
        public async Task<IActionResult> Calendar()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
            {
                // Handle the case where the user's ID is not found
                return NotFound();
            }

            var upcomingReminders = await _context.Reminder
                .Where(r => r.ApplicationUser.Id == userId && r.ReminderDate > DateTime.Now)
                .ToListAsync();

            return View(upcomingReminders);
        }

        // GET: Discharge/Details/5
        public async Task<IActionResult> Details(int? id)
        {


            if (id == null || _context.Reminder == null)
            {
                return NotFound();
            }

            var reminder = await _context.Reminder
            .Include(b => b.ApplicationUser)
            .FirstOrDefaultAsync(m => m.ReminderId == id);
            if (reminder == null)
            {
                return NotFound();
            }

            return View(reminder);

        }

        private void SendReminder(Reminder reminder)
        {
            var user = _context.Users.Find(reminder.UserID);

            string subject = "Reminder: " + reminder.ReminderType;
            string body = "Description: " + reminder.Description + "<br>Reminder Date: " + reminder.ReminderDate;
            // Update the reminder to mark it as completed
            reminder.IsCompleted = true;
            _context.SaveChanges(); // Save changes in the database
        }
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReminderId,ReminderType,ReminderDate,Description,IsCompleted,Priority,IsReccuring,Location,UserID")] Reminder reminder)
        {
            // Retrieve the user's ID from the claims
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            reminder.UserID = userId;

            // Set the UserID property of the Discharge entity
            reminder.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (Request.Form["IsRecurring"] == "on")
            {
                reminder.IsRecurring = true;
            }
            else
            {
                reminder.IsRecurring = false;
            }

            //_context.Add(reminder);
            //await _context.SaveChangesAsync();
            //TempData["SuccessMessage"] = "Reminder created Successfully!";
            //return RedirectToAction(nameof(Index));

            //ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", reminder.UserID);

            //return View(reminder);

             _context.Add(reminder);
             await _context.SaveChangesAsync();
             // Schedule a background task to send the reminder
             var now = DateTime.Now;
             var timeUntilReminder = reminder.ReminderDate - now;
                // Schedule a delayed task to send the reminder
             Task.Delay(timeUntilReminder).ContinueWith(t => SendReminder(reminder));
             TempData["SuccessMessage"] = "Reminder created Successfully!";
             return RedirectToAction(nameof(Index));
            

            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", reminder.UserID);
            return View(reminder);

        }
       
        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reminder == null)
            {
                return NotFound();
            }

            var reminder = await _context.Reminder.FindAsync(id);
            if (reminder == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", reminder.UserID);
            return View(reminder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReminderId,ReminderType,ReminderDate,Description,IsCompleted,Priority,IsReccuring,Location,UserID")] Reminder reminder)
        {
            if (id != reminder.ReminderId)
            {
                return NotFound();
            }



            _context.Update(reminder);
            await _context.SaveChangesAsync();


            if (!ReminderExists(reminder.ReminderId))
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));

            //ViewData["UserID"] = new SelectList(_context.Users, "Id", "FirstName", booking.UserID);


            var users = _context.Users.Select(user => new
            {
                Id = user.Id,
                FullName = user.FirstName + " " + user.LastName // Concatenate first name and last name
            }).ToList();

            ViewData["UserID"] = new SelectList(users, "Id", "FullName");

            return View(reminder);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reminder == null)
            {
                return NotFound();
            }

            var reminder = await _context.Reminder
            .Include(b => b.ApplicationUser)
            .FirstOrDefaultAsync(m => m.ReminderId == id);
            if (reminder == null)
            {
                return NotFound();
            }

            return View(reminder);
        }

        // POST: Discharge/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reminder == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.Reminder'  is null.");
            }
            var reminder = await _context.Reminder.FindAsync(id);
            if (reminder != null)
            {
                _context.Reminder.Remove(reminder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool ReminderExists(int id)
        {
            return (_context.Reminder?.Any(e => e.ReminderId == id)).GetValueOrDefault();
        }


    }
}
