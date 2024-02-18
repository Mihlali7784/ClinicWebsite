using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class ManageVaccController : Controller
    {
        private readonly PHCApplicationDbContext dbContext;
        //ApplicationDbContext class so that it can access the database and perform create,read,update and delete,  operations for the "Fighters" entity.
        public ManageVaccController(PHCApplicationDbContext Db)
        {
            dbContext = Db;
        }
        public IActionResult Index()
        {
            IEnumerable<VaccineAvail> objList = dbContext.AvailVacc;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VaccineAvail games)
        {
            if (ModelState.IsValid)
            {
                dbContext.AvailVacc.Add(games);
                dbContext.SaveChanges();
                return RedirectToAction("Index");


            }
            return View(games);


        }
        public IActionResult Update(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }
            var obj = dbContext.AvailVacc.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(VaccineAvail games)
        {
            dbContext.AvailVacc.Update(games);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? ID)
        {
            var obj = dbContext.AvailVacc.Find(ID);
            if (obj == null)
            {
                return NotFound();
            }

            dbContext.AvailVacc.Remove(obj);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult SendRequest()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendRequest(OrderVacc games)
        {
            if (ModelState.IsValid)
            {
                dbContext.OrderVacc.Add(games);
                dbContext.SaveChanges();
                return RedirectToAction("Index1");


            }
            return View(games);


        }
        public IActionResult Index1()
        {
            IEnumerable<VaccineAvail> objList = dbContext.AvailVacc;
            return View(objList);
        }
    }
}
