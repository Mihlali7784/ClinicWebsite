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


        //Sub 1 Chronic Medication
        public ActionResult DocterDashboardSub1()
        {
            return View();
        }
        public ActionResult pharmacistDashboardChronicMedication()
        {
            return View();
        }
        public ActionResult PatientDashboard()
        {
            return View();
        }



        //Sub 2 Vaccination
        public ActionResult DocterDashboardSub2()
        {
            return View();
        }
        public ActionResult AdminDashboardVaccination()
        {
            return View();
        }
        public IActionResult PatientDashboardVaccination()
        {
            return View();
        }

        //Sub 3 Mental health & Wellness
        public ActionResult DocterDashboardSub3()
        {
            return View();
        }
        public ActionResult pharmacistDashboardMentalHealth()
        {
            return View();
        }
       
        public IActionResult PatientDashboardMentalhealth()
        {
            return View();
        }

        //Sub 4 Specialized Medical Procedures
        
        public ActionResult DocterDashboardSub4()
        {
            return View();
        }
       
        public ActionResult pharmacistDashboardMedicalProcedures()
        {
            return View();
        }
       
        public ActionResult AdminDashboardMedicalProcedures()
        {
            return View();
        }
        
        public IActionResult PatientDashboardMedicalProcedures()
        {
            return View();
        }

        //Sub 5 Prenatal Care
        public ActionResult DocterDashboardSub5()
        {
            return View();
        }
        public ActionResult pharmacistDashboardPrenatalCare()
        {
            return View();
        }
        public IActionResult AdminDashboardPrenatalCare()
        {
            return View();
        }
        public IActionResult PatientDashboardPrenatalCare()
        {
            return View();
        }
        public IActionResult pharmacistDashboardVaccination()
        {
            return View();
        }
        public IActionResult DoctorAssistantDashboardVaccination()
        {
            return View();
        }

    }
}
