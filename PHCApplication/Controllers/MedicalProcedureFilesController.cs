using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class MedicalProcedureFilesController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public MedicalProcedureFilesController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MedicalProcedureFiles
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.MedicalProcedureFile.Include(m => m.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: MedicalProcedureFiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MedicalProcedureFile == null)
            {
                return NotFound();
            }

            var medicalProcedureFile = await _context.MedicalProcedureFile
                .Include(m => m.ApplicationUser)
                .FirstOrDefaultAsync(m => m.MedicalProcedureFileId == id);
            if (medicalProcedureFile == null)
            {
                return NotFound();
            }

            return View(medicalProcedureFile);
        }

        // GET: MedicalProcedureFiles/Create
        public IActionResult Create()
        {
            // ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");

            return View();
        }

        // POST: MedicalProcedureFiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicalProcedureFileId,Date,MedicalProcedure,Part,Room,Desc,status,Weight,Heigh,Symptoms,CurrentMedication,Allergies,Treatment,BloodType,SmokingHabit,AlcoholConsumption,UserID")] MedicalProcedureFile medicalProcedureFile)
        {
            // ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");

            _context.Add(medicalProcedureFile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        // GET: MedicalProcedureFiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MedicalProcedureFile == null)
            {
                return NotFound();
            }

            var medicalProcedureFile = await _context.MedicalProcedureFile.FindAsync(id);
            if (medicalProcedureFile == null)
            {
                return NotFound();
            }
            // ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");

            return View(medicalProcedureFile);
        }

        // POST: MedicalProcedureFiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedicalProcedureFileId,Date,MedicalProcedure,Part,Room,Desc,status,Weight,Heigh,Symptoms,CurrentMedication,Allergies,Treatment,BloodType,SmokingHabit,AlcoholConsumption,UserID")] MedicalProcedureFile medicalProcedureFile)
        {
            if (id != medicalProcedureFile.MedicalProcedureFileId)
            {
                return NotFound();
            }


            _context.Update(medicalProcedureFile);
            await _context.SaveChangesAsync();
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");
            return RedirectToAction(nameof(Index));
        }

        // GET: MedicalProcedureFiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MedicalProcedureFile == null)
            {
                return NotFound();
            }

            var medicalProcedureFile = await _context.MedicalProcedureFile
                .Include(m => m.ApplicationUser)
                .FirstOrDefaultAsync(m => m.MedicalProcedureFileId == id);
            if (medicalProcedureFile == null)
            {
                return NotFound();
            }

            return View(medicalProcedureFile);
        }

        // POST: MedicalProcedureFiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MedicalProcedureFile == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.MedicalProcedureFile'  is null.");
            }
            var medicalProcedureFile = await _context.MedicalProcedureFile.FindAsync(id);
            if (medicalProcedureFile != null)
            {
                _context.MedicalProcedureFile.Remove(medicalProcedureFile);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalProcedureFileExists(int id)
        {
            return (_context.MedicalProcedureFile?.Any(e => e.MedicalProcedureFileId == id)).GetValueOrDefault();
        }
    }
}
