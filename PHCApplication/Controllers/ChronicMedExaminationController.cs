using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class ChronicMedExaminationController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public ChronicMedExaminationController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CollectionChronics
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.Examination.Include(c => c.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: CollectionChronics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Examination == null)
            {
                return NotFound();
            }

            var examination = await _context.Examination
                .Include(c => c.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (examination == null)
            {
                return NotFound();
            }

            return View(examination);
        }

        // GET: CollectionChronics/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");

            return View();
        }

        // POST: CollectionChronics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserID,DoctorName,PatientName,PatientLastName,PatientIdNumber,BloodType,Symptoms,Diagnose")] Examination examination)
        {
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");

            _context.Add(examination);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: CollectionChronics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Examination == null)
            {
                return NotFound();
            }

            var examination = await _context.Examination.FindAsync(id);
            if (examination == null)
            {
                return NotFound();
            }

            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");
            return View(examination);
        }

        // POST: CollectionChronics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserID,DoctorName,PatientName,PatientLastName,PatientIdNumber,BloodType,Symptoms,Diagnose")] Examination examination)
        {
            if (id != examination.Id)
            {
                return NotFound();
            }

            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");



            try
            {

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollectionChronicExists(examination.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            _context.Update(examination);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: CollectionChronics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Examination == null)
            {
                return NotFound();
            }

            var examination = await _context.Examination
                .Include(c => c.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (examination == null)
            {
                return NotFound();
            }

            return View(examination);
        }

        // POST: CollectionChronics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CollectionChronic == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.Examination'  is null.");
            }
            var examination = await _context.Examination.FindAsync(id);
            if (examination != null)
            {
                _context.Examination.Remove(examination);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CollectionChronicExists(int id)
        {
            return (_context.Examination?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
