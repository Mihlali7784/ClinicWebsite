using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;

namespace PHCApplication.Controllers
{
    public class PrenatalController : Controller
    {
        private readonly PHCApplicationDbContext dbContext;
        public PrenatalController(PHCApplicationDbContext dBD)
        {
            dbContext = dBD;
        }

        public IActionResult Index()
        {
            IEnumerable<PrenatalAppointment> objList = dbContext.PrenatalApp;
            return View(objList);
        }


        public ActionResult CreatePlan()
        {
            //     var viewModel = new PrenatalCarePlan
            //     {
            //         // Populate the list of vitamins
            //         vitaminID = new List<SelectListItem>
            // {
            //     new SelectListItem { Value = "Multivitamin", Text = "Pre-Multivitamin" },
            //     new SelectListItem { Value = "Omega3", Text = "Omega-3 Fatty Acids" },
            //     new SelectListItem { Value = "Calcium", Text = "GOT-Calcium" },
            //     new SelectListItem { Value = "VitaminD", Text = "Vitamin D" },
            //     new SelectListItem { Value = "VitaminB12", Text = "Vitamin B12" },

            //     // Add more vitamins as needed
            // }
            //     };

            return View();
        }

        //[HttpPost]
        public ActionResult SubmitAction()
        {
            return View();
        }


        public ActionResult ViewPlanDetails(int id)
        {
            var prenatalCarePlan = dbContext.PrenatalCarePlans.Find(id);

            if (prenatalCarePlan == null)
            {
                // Handle the case where the prenatal care plan is not found (e.g., show an error message)
                return View("NotFound");
            }

            return View(prenatalCarePlan);
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult RequestAppointment(PrenatalAppointment app)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    dbContext.PrenatalApp.Add(app);
                    dbContext.SaveChanges();
                    //return Json(new { success = true });
                    return View("AppointmentList");
                }
                catch
                {
                    // Log the exception or handle it accordingly
                    ModelState.AddModelError("", "An error occurred while booking the appointment.");
                    // You can also redirect to an error view or display a user-friendly error message.
                }
            }


            return View(app);
        }

        public IActionResult AppointmentList()
        {
            return View();
        }

        //COMPLAINT SECTION
        public IActionResult AddComplaint(Complaint complaint)
        {
            if (ModelState.IsValid)
            {
                using (var dbContext = new PHCApplicationDbContext())
                {
                    // Map the ComplaintModel to the Complaint entity
                    var complaintEntity = new Complaint
                    {
                        Name = complaint.Name,
                        Email = complaint.Email,
                        Subject = complaint.Subject,
                        Message = complaint.Message
                    };

                    // Save the complaint to the database
                    dbContext.Complaints.Add(complaintEntity);
                    dbContext.SaveChanges();
                }

                // Redirect to a thank you page or the homepage
                return RedirectToAction("ThankYou");
            }

            // If ModelState is not valid, return to the form with validation errors
            return View(complaint);
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult RequestAmbulance()
        {
            return View();
        }

        public IActionResult ViewPrescriptions()
        {
            return View();
        }

        public IActionResult AvailableDoctors()
        {
            return View();
        }

        //CHAT MESSAGES
        public IActionResult ChatIndex()
        {

            return View("ChatIndex");
        }
        public JsonResult GetMessages()
        {
            using (var dbContext = new PHCApplicationDbContext()) ;
            // Implement logic to fetch chat messages from your database
            var messages = dbContext.ChatMessages.ToList(); /* Retrieve messages from the database */;
            return Json(messages);
        }

        // Action to send a new chat message


        public ActionResult SendMessage(ChatMessage chat)
        {
            if (ModelState.IsValid)
            {
                // Implement logic to save the message to the database
                chat.Timestamp = DateTime.Now; // Set the timestamp
                /* Save the message to the database */

                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, errors = ModelState.Values.SelectMany(v => v.Errors) });
            }
        }

        //Bump Plan
        public IActionResult Bumplan()
        {
            return View();
        }

        public IActionResult ViewPlanDetails()
        {
            return View();
        }
    }
}
