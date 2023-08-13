using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PHCApplication.Controllers
{
    public class DashboardController : Controller
    {
     
        /*
         * 
         Remeber you all use one user
         *
         */

        public ActionResult PatientDashboard()
        {
            return View();
        }
        /*
         ********************************* 
         */

        //Sub 1 Chronic Medication
        public ActionResult DocterDashboardSub1()
        {
            return View();
        }

        public ActionResult pharmacistDashboardSub1()
        {
            return View();
        }



        //Sub 2 Vaccination
        public ActionResult DocterDashboardSub2()
        {
            return View();
        }
        public ActionResult pharmacistDashboardSub2()
        {
            return View();
        }

        //Sub 3 Mental health & Wellness
        public ActionResult DocterDashboardSub3()
        {
            return View();
        }
        public ActionResult pharmacistDashboardSub3()
        {
            return View();
        }

        //Sub 4 Specialized Medical Procedures
        public ActionResult DocterDashboardSub4()
        {
            return View();
        }

        public ActionResult pharmacistDashboardSub4()
        {
            return View();
        }
        public ActionResult AdminDashboardSub4()
        {
            return View();
        }

        //Sub 5 Prenatal Care
        public ActionResult DocterDashboardSub5()
        {
            return View();
        }
        public ActionResult pharmacistDashboardSub5()
        {
            return View();
        }
        public IActionResult AdminDashboardSub5()
        {
            return View();
        }

    }
}
