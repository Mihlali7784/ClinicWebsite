using Microsoft.AspNetCore.Mvc;

namespace PHCApplication.Controllers
{
    public class TeleHealthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
