using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class MedicalHistoriesController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public MedicalHistoriesController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MedicalHistories
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.MedicalHistory.Include(m => m.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: MedicalHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MedicalHistory == null)
            {
                return NotFound();
            }

            var medicalHistory = await _context.MedicalHistory
                .Include(m => m.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicalHistory == null)
            {
                return NotFound();
            }

            return View(medicalHistory);
        }

        // GET: MedicalHistories/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");
            return View();
        }

        // POST: MedicalHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserID,HistoryMentalHealthTreatment,CurrentMentalHealthTreatment,Substance,Date")] MedicalHistory medicalHistory)
        {

            _context.Add(medicalHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");
        }

        // GET: MedicalHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MedicalHistory == null)
            {
                return NotFound();
            }

            var medicalHistory = await _context.MedicalHistory.FindAsync(id);
            if (medicalHistory == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");
            return View(medicalHistory);
        }

        // POST: MedicalHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserID,HistoryMentalHealthTreatment,CurrentMentalHealthTreatment,Substance,Date")] MedicalHistory medicalHistory)
        {
            if (id != medicalHistory.Id)
            {
                return NotFound();
            }

            _context.Update(medicalHistory);
            await _context.SaveChangesAsync();
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");
            return RedirectToAction(nameof(Index));
        }

        // GET: MedicalHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MedicalHistory == null)
            {
                return NotFound();
            }

            var medicalHistory = await _context.MedicalHistory
                .Include(m => m.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicalHistory == null)
            {
                return NotFound();
            }

            return View(medicalHistory);
        }

        // POST: MedicalHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MedicalHistory == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.MedicalHistory'  is null.");
            }
            var medicalHistory = await _context.MedicalHistory.FindAsync(id);
            if (medicalHistory != null)
            {
                _context.MedicalHistory.Remove(medicalHistory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalHistoryExists(int id)
        {
            return (_context.MedicalHistory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
