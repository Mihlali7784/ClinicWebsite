using Microsoft.AspNetCore.Mvc;

namespace PHCApplication.Controllers
{
    public class MonitoringController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
