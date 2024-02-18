using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class VaccinationController : Controller
    {
        private readonly PHCApplicationDbContext dbContext;
        public VaccinationController(PHCApplicationDbContext dBD)
        {
            dbContext = dBD;
        }
        public IActionResult Index()
        {
            IEnumerable<Details> objList = dbContext.Detail;
            return View(objList);

        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]

        public IActionResult Details(Details details)
        {
            if (ModelState.IsValid)
            {
                dbContext.Detail.Add(details);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(details);
        }
        

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Update(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = dbContext.Detail.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }
        public IActionResult Update(Details details)
        {
            //dbContext.Detail.Update(details);
            //dbContext.SaveChanges();

            //return RedirectToAction("Index");
            if (ModelState.IsValid)
            {
                dbContext.Detail.Update(details);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(details);
        }
        public IActionResult ManageVaccine()
        {
            return View();
        }
        public IActionResult OrderVaccine(OrderVacc order)
        {

            if (ModelState.IsValid)
            {
                dbContext.OrderVacc.Add(order);
                dbContext.SaveChanges();
                return RedirectToAction("Index1");
            }
            return View(order);
        }
        public IActionResult GenerateCertificate()
        {
            return View();
        }
        public IActionResult GenCert()
        {
            return View();
        }
        public IActionResult RatingReview()
        {
            return View();
        }
        public IActionResult ReportEvent()
        {
            return View();
        }
        public IActionResult More()
        {
            return View();
        }
        public IActionResult ReadEvents()
        {
            return View();
        }
        public IActionResult Index1()
        {
            IEnumerable<OrderVacc> objList = dbContext.OrderVacc;
            return View(objList);
        }
        public IActionResult Index2()
        {
            IEnumerable<Appoint> objList = dbContext.Appoints;
            return View(objList);
        }

    }
}
