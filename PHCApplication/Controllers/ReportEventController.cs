using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class ReportEventController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        //ApplicationDbContext class so that it can access the database and perform create,read,update and delete,  operations for the "Fighters" entity.
        public ReportEventController(PHCApplicationDbContext Db)
        {
            _context = Db;
        }
        // GET: ReportEventController
        public ActionResult Index()
        {
            IEnumerable<ReportEvent> reportevent = _context.Events;
            return View(reportevent);
        }

        public IActionResult Index1()
        {
            IEnumerable<Appoint> reportevent = _context.Appoints;
            return View(reportevent);

        }

        // GET: ReportEventController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReportEventController/Create
        public ActionResult Create()
        {

            {
                return View();
            }
        }

        // POST: ReportEventController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReportEvent reportEvent)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Events.Add(reportEvent);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "You have Successfully reported your event we will get back to you shortly";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid";
                    return View(reportEvent);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: ReportEventController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReportEventController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReportEventController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReportEventController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult RatingReview()
        {

            {
                return View();
            }
        }

        // POST: ReportEventController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RatingReview(RatingReview rating)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Ratings.Add(rating);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "You have Successfully rated us we will get back to you shortly";
                    return RedirectToAction("Index2");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid";
                    return View(rating);
                }
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Index2()
        {

            return View();
        }
    }
}
