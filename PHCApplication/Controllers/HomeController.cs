using Microsoft.AspNetCore.Mvc;
using PHCApplication.Models;
using System.Diagnostics;

namespace PHCApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Models.Content obj;
            List<Models.Content> lobj = new List<Content>();
            obj = new Content();
            obj.Title = "Vaccination";
            obj.text = "To know more about Vaccination click here ";
            obj.img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSVay0CjUSabr5JdLHLh3OYNfR_bd6qjtRn3w&usqp=CAU";
            lobj.Add(obj);

            obj = new Content();
            obj.Title = "Prenatal Care";
            obj.text = "To know more about Prenatal Care click here ";
            obj.img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTuK0qAi3_W4zaEYr2bSz0U4rHdnYx-vBcDFg&usqp=CAU";

            lobj.Add(obj);

            obj = new Content();
            obj.Title = "Specialized medical procedures";
            obj.text = "To know more about Specialized medical procedures click here ";
            obj.img = "https://www.shutterstock.com/image-vector/vector-illustration-group-surgeons-doing-260nw-193237727.jpg";

            lobj.Add(obj);

            obj = new Content();
            obj.Title = "Chronic medication";
            obj.text = "To know more about Chronic medication click here ";
            obj.img = "https://static.vecteezy.com/system/resources/thumbnails/004/103/802/small_2x/medical-drugs-icons-vector.jpg";

            lobj.Add(obj);

            obj = new Content();
            obj.Title = "Mental health and wellness";
            obj.text = "To know more about Mental health and wellness click here ";
            obj.img = "https://media.istockphoto.com/id/1319874358/vector/mental-health-medical-treatment.jpg?s=612x612&w=0&k=20&c=LoBwRcqLaTCPNq3d-pAaU8W9fsh8vpvAeGKMn7B9GTg=";

            lobj.Add(obj);

            return View(lobj);

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        { 
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult OurServices()
        {
            return View();
        }
        public IActionResult MeetOurTeam()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult PatientDashboard()
        {
            return View();
        }
        public IActionResult PharmacistDashboard()
        {
            return View();
        }
        public IActionResult AdministratorDashboard()
        {
            return View();
        }
        public IActionResult CommonDashboard()
        {
            return View();
        }

        //Landing page
        public IActionResult IndexPage()
        {
            return View();
        }
        //medical procedure admin landing page
        public IActionResult AdminMedicalLandingPage()
        {
            return View();
        }
        //medical procedure admin landing page
        public IActionResult DocSpecialisedLandingPage()
        {
            return View();
        }
        //medical procedure patient landing page
        public IActionResult PatientMedicalLandingPage()
        {
            return View();
        }
        public IActionResult PharmacistMedicalLandingPage()
        {
            return View();
        }


    }
}