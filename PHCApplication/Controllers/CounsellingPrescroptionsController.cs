using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class CounsellingPrescroptionsController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public CounsellingPrescroptionsController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CounsellingPrescroptions
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.CounsellingPrescroption.Include(c => c.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: CounsellingPrescroptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CounsellingPrescroption == null)
            {
                return NotFound();
            }

            var counsellingPrescroption = await _context.CounsellingPrescroption
                .Include(c => c.ApplicationUser)
                .FirstOrDefaultAsync(m => m.PrescroptionId == id);
            if (counsellingPrescroption == null)
            {
                return NotFound();
            }

            return View(counsellingPrescroption);
        }

        // GET: CounsellingPrescroptions/Create
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

        // POST: CounsellingPrescroptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrescroptionId,UserID,Note,Desc")] CounsellingPrescroption counsellingPrescroption)
        {
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", counsellingPrescroption.UserID);

            _context.Add(counsellingPrescroption);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: CounsellingPrescroptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CounsellingPrescroption == null)
            {
                return NotFound();
            }

            var counsellingPrescroption = await _context.CounsellingPrescroption.FindAsync(id);
            if (counsellingPrescroption == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", counsellingPrescroption.UserID);
            return View(counsellingPrescroption);
        }

        // POST: CounsellingPrescroptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrescroptionId,UserID,Note,Desc")] CounsellingPrescroption counsellingPrescroption)
        {
            if (id != counsellingPrescroption.PrescroptionId)
            {
                return NotFound();
            }


            try
            {
                _context.Update(counsellingPrescroption);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CounsellingPrescroptionExists(counsellingPrescroption.PrescroptionId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
            ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", counsellingPrescroption.UserID);
        }

        // GET: CounsellingPrescroptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CounsellingPrescroption == null)
            {
                return NotFound();
            }

            var counsellingPrescroption = await _context.CounsellingPrescroption
                .Include(c => c.ApplicationUser)
                .FirstOrDefaultAsync(m => m.PrescroptionId == id);
            if (counsellingPrescroption == null)
            {
                return NotFound();
            }

            return View(counsellingPrescroption);
        }

        // POST: CounsellingPrescroptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CounsellingPrescroption == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.CounsellingPrescroption'  is null.");
            }
            var counsellingPrescroption = await _context.CounsellingPrescroption.FindAsync(id);
            if (counsellingPrescroption != null)
            {
                _context.CounsellingPrescroption.Remove(counsellingPrescroption);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CounsellingPrescroptionExists(int id)
        {
            return (_context.CounsellingPrescroption?.Any(e => e.PrescroptionId == id)).GetValueOrDefault();
        }
    }
}
