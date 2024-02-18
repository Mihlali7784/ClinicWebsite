// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PHCApplication.Areas.Identity.Data;

namespace PHCApplication.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public LoginModel(SignInManager<ApplicationUser> signInManager, ILogger<LoginModel> logger, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required(ErrorMessage = "Role is required.")]
            [EnumDataType(typeof(UserRole), ErrorMessage = "Invalid role.")]
            public UserRole Role { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/");
            }
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }
        
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    var user = await _userManager.FindByEmailAsync(Input.Email);
                    var emails = await _userManager.GetEmailAsync(user);


                    if (emails.Contains("Drtony@gmail.com")) //Chronic  doctor 
                    {
                        return RedirectToAction("DocterDashboardSub1", "Dashboard");
                    }
                    else if (emails.Contains("DrSotobe@gmail.com"))//Vaccination doctor 
                    {
                        return RedirectToAction("DocterDashboardSub2", "Dashboard");
                    }
                    else if (emails.Contains("Drmzibe@gmail.com"))//MentalHealth doctor 
                    {
                        return RedirectToAction("DocterDashboardSub3", "Dashboard");
                    }
                    else if (emails.Contains("Drsaints@gmail.com"))//Medical Procedures doctor 
                    {
                        return RedirectToAction("DocterDashboardSub4", "Dashboard");
                    }
                    else if (emails.Contains("DrVictoria@gmail.com"))//Medical Procedures doctor 
                    {
                        return RedirectToAction("DocterDashboardSub4", "Dashboard");
                    }
                    else if (emails.Contains("DrVictoria@gmail.com"))//Medical Procedures doctor 
                    {
                        return RedirectToAction("DocterDashboardSub4", "Dashboard");
                    }
                    else if (emails.Contains("DrLulama@gmail.com"))//Medical Procedures doctor 
                    {
                        return RedirectToAction("DocterDashboardSub4", "Dashboard");
                    }
                    else if (emails.Contains("DrNorth@gmail.com"))//Prenatal Care docter 
                    {
                        return RedirectToAction("DocterDashboardSub5", "Dashboard");

                    }
                    else if (emails.Contains("PharmMihlali@gmail.com"))//Chronic Medication Pharmacist
                    {
                        return RedirectToAction("pharmacistDashboardChronicMedication", "Dashboard");
                    }
                    else if (emails.Contains("PharmSiyamthanda@gmail.com"))//Mental Health Pharmacist
                    {
                        return RedirectToAction("pharmacistDashboardMentalHealth", "Dashboard");
                    }
                    else if (emails.Contains("PharmLandile@gmail.com"))//Medical Procedures Pharmacist
                    {
                        return RedirectToAction("pharmacistDashboardMedicalProcedures", "Dashboard");
                    }
                    else if (emails.Contains("PharmKatlego@gmail.com"))//Prenatal Care Pharmacist
                    {
                        return RedirectToAction("pharmacistDashboardPrenatalCare", "Dashboard");
                    }
                    else if (emails.Contains("AdminNdaba@gmail.com"))//Vaccination Admin
                    {
                        return RedirectToAction("AdminDashboardVaccination", "Dashboard");
                    }
                    else if (emails.Contains("AdminNqokiso@gmail.com"))//Medical Procedures Admin
                    {
                        return RedirectToAction("AdminDashboardMedicalProcedures", "Dashboard");
                    }
                    else if (emails.Contains("AdminKat@gmail.com"))//Prenatal Care Admin
                    {
                        return RedirectToAction("AdminDashboardPrenatalCare", "Dashboard");
                    }
                    else if (emails.Contains("AssistantSbiya@gmail.com"))//vacc pharm
                    {
                        return RedirectToAction("DoctorAssistantDashboardVaccination", "Dashboard");
                    }
                    else
                    {
                        return RedirectToAction("PatientMedicalLandingPage", "Home");
                    }


                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
