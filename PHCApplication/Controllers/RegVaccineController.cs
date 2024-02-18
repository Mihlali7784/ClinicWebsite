using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class RegVaccineController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        //ApplicationDbContext class so that it can access the database and perform create,read,update and delete,  operations for the "Fighters" entity.
        public RegVaccineController(PHCApplicationDbContext Db)
        {
            _context = Db;
        }
        // GET: RegVaccine
        public ActionResult Index()
        {
            IEnumerable<GenCert> genCerts = _context.GenCert;
            return View(genCerts);
        }

        // GET: RegVaccine/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegVaccine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegVaccine/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GenCert genCert)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.GenCert.Add(genCert);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "You have Successfully Generated  New Certificate";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid";
                    return View(genCert);
                }
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Index1()
        {
            IEnumerable<Appoint> genCerts = _context.Appoints;
            return View(genCerts);
        }
        public ActionResult Index2()
        {
            IEnumerable<ReportEvent> genCerts = _context.Events;
            return View(genCerts);
        }
        public IActionResult Delete(int? ID)
        {
            var obj = _context.Appoints.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Appoints.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index1");
        }
        public IActionResult Delete1(int? ID)
        {
            var obj = _context.Events.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Events.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index2");
        }

    }
}
