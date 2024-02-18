using Microsoft.AspNetCore.Mvc;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class RegisterVaccinationController : Controller
    {
        private readonly PHCApplicationDbContext _context;
        //ApplicationDbContext class so that it can access the database and perform create,read,update and delete,  operations for the "Fighters" entity.
        public RegisterVaccinationController(PHCApplicationDbContext Db)
        {
            _context = Db;
        }
        // GET: RegisterVaccinationController
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: RegisterVaccinationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterVaccinationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterVaccinationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Appoint register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Appoints.Add(register);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "You have Successfully Registered to vaccinate";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid";
                    return View(register);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterVaccinationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterVaccinationController/Edit/5
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

        // GET: RegisterVaccinationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterVaccinationController/Delete/5
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
        public ActionResult Index2()
        {

            return View();
        }
    }
}
