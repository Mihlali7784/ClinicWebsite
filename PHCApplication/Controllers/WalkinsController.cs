using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class WalkinsController : Controller
    {
        private readonly PHCApplicationDbContext _context;

        public WalkinsController(PHCApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Walk_in
        public async Task<IActionResult> Index()
        {
            var walkIns = await _context.walk_In.ToListAsync();
            return View(walkIns);
        }

        public async Task<IActionResult> eee()
        {
            var walkIns = await _context.walk_In.ToListAsync();
            return View(walkIns);
        }

        // GET: Walk_in/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Walk_in/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,DateTime,Specialisation,Description")] Walk_in walk_in)
        {
            if (ModelState.IsValid)
            {
                _context.Add(walk_in);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(walk_in);
        }

        // Other CRUD actions (Edit, Details, Delete) can be added here

        private bool Walk_inExists(int id)
        {
            return _context.walk_In.Any(e => e.Id == id);
        }

    }
}
