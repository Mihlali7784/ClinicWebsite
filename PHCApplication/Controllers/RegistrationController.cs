using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Data;
using PHCApplication.Models;



namespace PHCApplication.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(PrenatalPatientReg model)
        {
            if (ModelState.IsValid)
            {
                // Create a new patient instance and map the data from the model
                var newPatient = new PrenatalPatientReg
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    PreferredLanguage = model.PreferredLanguage,
                    DueDate = model.DueDate,
                    Gender = model.Gender,
                    EmergencyContactName = model.EmergencyContactName
                    // Map other properties as needed
                };

                // Save the patient to the database
                PHCApplicationDbContext context = new PHCApplicationDbContext();
                context.PrenatalPatients.Add(newPatient);
                context.SaveChanges();

                // Redirect to the registration success page
                return RedirectToAction("RegistrationSuccess");
            }

            // If there are validation errors, redisplay the registration form
            return View(model);
        }


        public ActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}

