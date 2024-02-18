using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;
using System.Security.Claims;

namespace PHCApplication.Controllers
{
    public class AddPatientProcedureController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public AddPatientProcedureController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.Patientss.Include(b => b.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Patientss == null)
            {
                return NotFound();
            }

            var patient = await _context.Patientss
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
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
        public async Task<IActionResult> Create([Bind("ID,Date,FirstName,LastName,DateOfBirt,Email,ContactNumber,Address,StreetAddress,PostalAddress,MaritalStatus,Username,Password,ConfirmPassword,UserID")] Patientss patient)
        {

            // Retrieve the user's ID from the claims
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Set the UserID property of the Booking entity
            patient.UserID = userId;

            _context.Add(patient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", patient.UserID);
            return View(patient);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Patientss == null)
            {
                return NotFound();
            }

            var patient = await _context.Patientss.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", patient.UserID);
            return View(patient);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Date,FirstName,LastName,DateOfBirt,Email,ContactNumber,Address,StreetAddress,PostalAddress,MaritalStatus,Username,Password,ConfirmPassword,UserID")] Patientss patient)
        {
            if (id != patient.ID)
            {
                return NotFound();
            }



            _context.Update(patient);
            await _context.SaveChangesAsync();


            if (!PatientExists(patient.ID))
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

            return View(patient);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Patientss == null)
            {
                return NotFound();
            }

            var patient = await _context.Patientss
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Patientss == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.Patient'  is null.");
            }
            var patient = await _context.Patientss.FindAsync(id);
            if (patient != null)
            {
                _context.Patientss.Remove(patient);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientExists(int id)
        {
            return (_context.Patientss?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
