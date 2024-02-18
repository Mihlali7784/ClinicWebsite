using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class CollectionChronicsController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public CollectionChronicsController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CollectionChronics
        public async Task<IActionResult> Index()
        {
            var pHCApplicationDbContext = _context.CollectionChronic.Include(c => c.ApplicationUser);
            return View(await pHCApplicationDbContext.ToListAsync());
        }

        // GET: CollectionChronics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CollectionChronic == null)
            {
                return NotFound();
            }

            var collectionChronic = await _context.CollectionChronic
                .Include(c => c.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (collectionChronic == null)
            {
                return NotFound();
            }

            return View(collectionChronic);
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
        public async Task<IActionResult> Create([Bind("Id,UserID,CollectionDate,Desc,status")] CollectionChronic collectionChronic)
        {
            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");

            _context.Add(collectionChronic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: CollectionChronics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CollectionChronic == null)
            {
                return NotFound();
            }

            var collectionChronic = await _context.CollectionChronic.FindAsync(id);
            if (collectionChronic == null)
            {
                return NotFound();
            }

            ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
            {
                Id = u.Id,
                FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
            }), "Id", "FullName");
            return View(collectionChronic);
        }

        // POST: CollectionChronics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserID,CollectionDate,Desc,status")] CollectionChronic collectionChronic)
        {
            if (id != collectionChronic.Id)
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
                if (!CollectionChronicExists(collectionChronic.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            _context.Update(collectionChronic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: CollectionChronics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CollectionChronic == null)
            {
                return NotFound();
            }

            var collectionChronic = await _context.CollectionChronic
                .Include(c => c.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (collectionChronic == null)
            {
                return NotFound();
            }

            return View(collectionChronic);
        }

        // POST: CollectionChronics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CollectionChronic == null)
            {
                return Problem("Entity set 'PHCApplicationDbContext.CollectionChronic'  is null.");
            }
            var collectionChronic = await _context.CollectionChronic.FindAsync(id);
            if (collectionChronic != null)
            {
                _context.CollectionChronic.Remove(collectionChronic);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CollectionChronicExists(int id)
        {
            return (_context.CollectionChronic?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
