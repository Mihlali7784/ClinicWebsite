using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;
using System.Security.Claims;

namespace PHCApplication.Controllers
{
    public class OperationMedicalProcedureController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public OperationMedicalProcedureController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.Procedure.Include(b => b.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Procedure == null)
            {
                return NotFound();
            }

            var procedures = await _context.Procedure
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ProcedureId == id);
            if (procedures == null)
            {
                return NotFound();
            }

            return View(procedures);
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
        public async Task<IActionResult> Create([Bind("ProcedureId,ProcedureName,ProcedureType,ProcedureDateTime,Description,Equipment,Duration,RoomNumber,TermsAndConditions,UserID")] Procedure procedures)
        {

            // Retrieve the user's ID from the claims
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Set the UserID property of the Booking entity
            procedures.UserID = userId;

            _context.Add(procedures);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", procedures.UserID);
            return View(procedures);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Procedure == null)
            {
                return NotFound();
            }

            var procedures = await _context.Procedure.FindAsync(id);
            if (procedures == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", procedures.UserID);
            return View(procedures);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProcedureId,ProcedureName,ProcedureType,ProcedureDateTime,Description,Equipment,Duration,RoomNumber,,TermsAndConditions,UserID")] Procedure procedures)
        {
            if (id != procedures.ProcedureId)
            {
                return NotFound();
            }



            _context.Update(procedures);
            await _context.SaveChangesAsync();


            if (!ProcedureExists(procedures.ProcedureId))
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

            return View(procedures);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Procedure == null)
            {
                return NotFound();
            }

            var procedures = await _context.Procedure
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ProcedureId == id);
            if (procedures == null)
            {
                return NotFound();
            }

            return View(procedures);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Procedure == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.Procedure'  is null.");
            }
            var procedures = await _context.Procedure.FindAsync(id);
            if (procedures != null)
            {
                _context.Procedure.Remove(procedures);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcedureExists(int id)
        {
            return (_context.Procedure?.Any(e => e.ProcedureId == id)).GetValueOrDefault();
        }
    }
}
