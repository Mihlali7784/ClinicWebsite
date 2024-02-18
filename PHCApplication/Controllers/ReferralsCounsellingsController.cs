using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class ReferralsCounsellingsController : Controller
    {
        
            private readonly PHCApplicationDbContext _context;

            public ReferralsCounsellingsController(PHCApplicationDbContext context)
            {
                _context = context;
            }

            // GET: ReferralsCounsellings
            public async Task<IActionResult> Index()
            {
                var pHCApplicationDbContext = _context.ReferralsCounselling.Include(r => r.ApplicationUser);
                return View(await pHCApplicationDbContext.ToListAsync());
            }

            // GET: ReferralsCounsellings/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null || _context.ReferralsCounselling == null)
                {
                    return NotFound();
                }

                var referralsCounselling = await _context.ReferralsCounselling
                    .Include(r => r.ApplicationUser)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (referralsCounselling == null)
                {
                    return NotFound();
                }

                return View(referralsCounselling);
            }

            // GET: ReferralsCounsellings/Create
            public IActionResult Create()
            {
                ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
                {
                    Id = u.Id,
                    FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
                }), "Id", "FullName");

                return View();
            }

            // POST: ReferralsCounsellings/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Id,UserID,Date,Medication,Desc")] ReferralsCounselling referralsCounselling)
            {
                ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
                {
                    Id = u.Id,
                    FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
                }), "Id", "FullName");

                _context.Add(referralsCounselling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // GET: ReferralsCounsellings/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null || _context.ReferralsCounselling == null)
                {
                    return NotFound();
                }

                var referralsCounselling = await _context.ReferralsCounselling.FindAsync(id);
                if (referralsCounselling == null)
                {
                    return NotFound();
                }
                ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
                {
                    Id = u.Id,
                    FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
                }), "Id", "FullName");

                return View(referralsCounselling);
            }

            // POST: ReferralsCounsellings/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("Id,UserID,Date,Medication,Desc")] ReferralsCounselling referralsCounselling)
            {
                ViewData["UserID"] = new SelectList(_context.Users.Select(u => new
                {
                    Id = u.Id,
                    FullName = u.FirstName + " " + u.LastName // Assuming you have FirstName and LastName properties in your User model
                }), "Id", "FullName");

                if (id != referralsCounselling.Id)
                {
                    return NotFound();
                }

                _context.Update(referralsCounselling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

            // GET: ReferralsCounsellings/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null || _context.ReferralsCounselling == null)
                {
                    return NotFound();
                }

                var referralsCounselling = await _context.ReferralsCounselling
                    .Include(r => r.ApplicationUser)
                    .FirstOrDefaultAsync(m => m.Id == id);
                if (referralsCounselling == null)
                {
                    return NotFound();
                }

                return View(referralsCounselling);
            }

            // POST: ReferralsCounsellings/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                if (_context.ReferralsCounselling == null)
                {
                    return Problem("Entity set 'PHCApplicationDbContext.ReferralsCounselling'  is null.");
                }
                var referralsCounselling = await _context.ReferralsCounselling.FindAsync(id);
                if (referralsCounselling != null)
                {
                    _context.ReferralsCounselling.Remove(referralsCounselling);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool ReferralsCounsellingExists(int id)
            {
                return (_context.ReferralsCounselling?.Any(e => e.Id == id)).GetValueOrDefault();
            }
    }
}
