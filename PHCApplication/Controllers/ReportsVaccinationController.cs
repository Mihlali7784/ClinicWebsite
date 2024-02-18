using Microsoft.AspNetCore.Mvc;

namespace PHCApplication.Controllers
{
    public class ReportsVaccinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
