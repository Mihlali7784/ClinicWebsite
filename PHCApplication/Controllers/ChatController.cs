using Microsoft.AspNetCore.Mvc;

namespace PHCApplication.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

