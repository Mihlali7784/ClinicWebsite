using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;
using System.Security.Claims;

namespace PHCApplication.Controllers
{
    public class ProcedureDiagnoseController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public ProcedureDiagnoseController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.Diagnose.Include(b => b.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Diagnose == null)
            {
                return NotFound();
            }

            var diagnose = await _context.Diagnose
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.DiagnoseId == id);
            if (diagnose == null)
            {
                return NotFound();
            }

            return View(diagnose);
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
        public async Task<IActionResult> Create([Bind("DiagnoseId,DiagnoseDateTime,Description,Treatment,MedicalFacility,FollowUpAppointment,MedicationDetails,UserID")] Diagnose diagnose)
        {

            // Retrieve the user's ID from the claims
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Set the UserID property of the Booking entity
            diagnose.UserID = userId;

            _context.Add(diagnose);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Added Diagnose!";
            return RedirectToAction(nameof(Index));

            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", diagnose.UserID);
            return View(diagnose);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Diagnose == null)
            {
                return NotFound();
            }

            var diagnose = await _context.Diagnose.FindAsync(id);
            if (diagnose == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", diagnose.UserID);
            return View(diagnose);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DiagnoseId,DiagnoseDateTime,Description,Treatment,MedicalFacility,FollowUpAppointment,MedicationDetails,UserID")] Diagnose diagnose)
        {
            if (id != diagnose.DiagnoseId)
            {
                return NotFound();
            }



            _context.Update(diagnose);
            await _context.SaveChangesAsync();


            if (!BookingExists(diagnose.DiagnoseId))
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

            return View(diagnose);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Diagnose == null)
            {
                return NotFound();
            }

            var diagnose = await _context.Diagnose
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.DiagnoseId == id);
            if (diagnose == null)
            {
                return NotFound();
            }

            return View(diagnose);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Diagnose == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.Diagnose'  is null.");
            }
            var diagnose = await _context.Diagnose.FindAsync(id);
            if (diagnose != null)
            {
                _context.Diagnose.Remove(diagnose);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return (_context.Diagnose?.Any(e => e.DiagnoseId == id)).GetValueOrDefault();
        }
    }
}
