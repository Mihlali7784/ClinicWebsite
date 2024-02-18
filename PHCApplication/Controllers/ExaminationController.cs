using Microsoft.AspNetCore.Mvc;

namespace PHCApplication.Controllers
{
    public class ExaminationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
