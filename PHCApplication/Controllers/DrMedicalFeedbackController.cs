using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;
using System.Security.Claims;

namespace PHCApplication.Controllers
{
    public class DrMedicalFeedbackController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public DrMedicalFeedbackController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.ChatFeedback.Include(b => b.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ChatFeedback == null)
            {
                return NotFound();
            }

            var chatfeedback = await _context.ChatFeedback
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ChatFeedbackId == id);
            if (chatfeedback == null)
            {
                return NotFound();
            }

            return View(chatfeedback);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChatFeedbackId,Date,Feedback,Subject,CommunicationRating,ResponseTimeInMinutes,UserID")] ChatFeedback chatfeedback)
        {

            // Retrieve the user's ID from the claims
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Set the UserID property of the Booking entity
            chatfeedback.UserID = userId;

            _context.Add(chatfeedback);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", chatfeedback.UserID);
            return View(chatfeedback);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ChatFeedback == null)
            {
                return NotFound();
            }

            var chatfeedback = await _context.ChatFeedback.FindAsync(id);
            if (chatfeedback == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", chatfeedback.UserID);
            return View(chatfeedback);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChatFeedbackId,Date,Feedback,Subject,CommunicationRatin,ResponseTimeInMinutes,UserID")] ChatFeedback chatfeedback)
        {
            if (id != chatfeedback.ChatFeedbackId)
            {
                return NotFound();
            }



            _context.Update(chatfeedback);
            await _context.SaveChangesAsync();


            if (!BookingExists(chatfeedback.ChatFeedbackId))
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

            return View(chatfeedback);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ChatFeedback == null)
            {
                return NotFound();
            }

            var chatfeedback = await _context.ChatFeedback
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ChatFeedbackId == id);
            if (chatfeedback == null)
            {
                return NotFound();
            }

            return View(chatfeedback);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ChatFeedback == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.Chat Feed Back'  is null.");
            }
            var chatfeedback = await _context.ChatFeedback.FindAsync(id);
            if (chatfeedback != null)
            {
                _context.ChatFeedback.Remove(chatfeedback);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return (_context.ChatFeedback?.Any(e => e.ChatFeedbackId == id)).GetValueOrDefault();
        }
    }
}
