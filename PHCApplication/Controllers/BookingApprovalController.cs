using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;
using System.Data;
using System.Security.Claims;

namespace PHCApplication.Controllers
{
    public class BookingApprovalController : Controller
    {


        private readonly PHCApplicationDbContext _context;

        public BookingApprovalController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.Bookings.Include(b => b.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var bookings = await _context.Bookings
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.BookingsId == id);
            if (bookings == null)
            {
                return NotFound();
            }

            return View(bookings);
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
        public async Task<IActionResult> Create([Bind("BookingsId,BookingDate,StartDateTime,EndDateTime,ServiceType,Status,Notes,DurationInMinute,AdditionalDetails,TermsAndConditions,UserID")] Bookings bookings)
        {

            // Retrieve the user's ID from the claims
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Set the UserID property of the Booking entity
            bookings.UserID = userId;

            _context.Add(bookings);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "booking accepted/created!";
            return RedirectToAction(nameof(Index));

            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", bookings.UserID);
            return View(bookings);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var bookings = await _context.Bookings.FindAsync(id);
            if (bookings == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", bookings.UserID);
            return View(bookings);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingsId,BookingDate,StartDateTime,EndDateTime,ServiceType,Status,Notes,DurationInMinute,AdditionalDetails,TermsAndConditions,UserID")] Bookings bookings)
        {
            if (id != bookings.BookingsId)
            {
                return NotFound();
            }



            _context.Update(bookings);
            await _context.SaveChangesAsync();


            if (!BookingExists(bookings.BookingsId))
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

            return View(bookings);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var bookings = await _context.Bookings
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.BookingsId == id);
            if (bookings == null)
            {
                return NotFound();
            }

            return View(bookings);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bookings == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.Booking'  is null.");
            }
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return (_context.Bookings?.Any(e => e.BookingsId == id)).GetValueOrDefault();
        }
    }
}

