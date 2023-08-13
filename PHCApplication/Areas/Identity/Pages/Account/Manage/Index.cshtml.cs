// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PHCApplication.Areas.Identity.Data;

namespace PHCApplication.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        ///     
        [TempData]
        public string UserNameChangeLimitMessage { get; set; }

        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

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
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }


            public Gender Gender { get; set; }

            [Display(Name = "Date of Birth")]
            public DateTime DateOfBirth { get; set; }

            public string Address { get; set; }

            [Display(Name = "Street Address")]
            public string StreetAddress { get; set; }

            public string City { get; set; }

            [Display(Name = "Postal Address")]
            public string PostalAddress { get; set; }

            [Display(Name = "Marital Status")]
            public MaritalStatus MaritalStatus { get; set; }
            [Phone]
            [Display(Name = "Contact Number")]
            public string ContactNumber { get; set; }

            [Required(ErrorMessage = "Role is required.")]
            [EnumDataType(typeof(UserRole), ErrorMessage = "Invalid role.")]
            public UserRole Role { get; set; }

            [Display(Name = "User Name")]
            public string UserName { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Profile Picture")]
            public byte[] ProfilePicture { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var firstName = user.FirstName;
            var lastName = user.LastName;
            var DateOfBirth = user.DateOfBirth;
            var gender = user.Gender;
            var address = user.Address;
            var streetAddress = user.StreetAddress;
            var PostalAddress = user.PostalAddress;
            var city = user.City;
            var postalCode = user.PostalAddress;
            var maritaStatus = user.MaritalStatus;
            var contactNumber = user.ContactNumber;
            var Role = user.Role;
            var profilePicture = user.ProfilePicture;
            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                UserName = userName,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = DateOfBirth,
                Gender = gender,
                Address = address,
                StreetAddress = streetAddress,
                City = city,
                PostalAddress = postalCode,
                MaritalStatus = maritaStatus,
                ContactNumber = contactNumber,
                Role = Role,
                ProfilePicture = profilePicture
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            var firstName = user.FirstName;
            var lastName = user.LastName;
            var DateOfBirth = user.DateOfBirth;
            var gender = user.Gender;
            var address = user.Address;
            var streetAddress = user.StreetAddress;
            var PostalAddress = user.PostalAddress;
            var city = user.City;
            var contactNumber = user.ContactNumber;
            var role = user.Role;
            var profilePicture = user.ProfilePicture;
            if (Input.FirstName != firstName)
            {
                user.FirstName = Input.FirstName;
                await _userManager.UpdateAsync(user);
            }
            if (Input.LastName != lastName)
            {
                user.LastName = Input.LastName;
                await _userManager.UpdateAsync(user);
            }
            if (Input.DateOfBirth != DateOfBirth)
            {
                user.DateOfBirth = Input.DateOfBirth;
                await _userManager.UpdateAsync(user);
            }
            if (Input.Gender != gender)
            {
                user.Gender = Input.Gender;
                await _userManager.UpdateAsync(user);
            }
            if (Input.Address != address)
            {
                user.Address = Input.Address;
                await _userManager.UpdateAsync(user);
            }
            if (Input.StreetAddress != streetAddress)
            {
                user.StreetAddress = Input.StreetAddress;
                await _userManager.UpdateAsync(user);
            }
            if (Input.PostalAddress != PostalAddress)
            {
                user.PostalAddress = Input.PostalAddress;
                await _userManager.UpdateAsync(user);
            }
            if (Input.City != city)
            {
                user.City = Input.City;
                await _userManager.UpdateAsync(user);
            }
            if(Input.Role != role)
            {
                user.Role = Input.Role;
                await _userManager.UpdateAsync(user);
            }
            if (Input.ContactNumber != contactNumber)
            {
                user.ContactNumber = Input.ContactNumber;
                await _userManager.UpdateAsync(user);
            }
            //if (Request.Form.Files.Count > 0)
            //{
            //    IFormFile file = Request.Form.Files.FirstOrDefault();
            //    MemoryStream datastream = null;
            //    if (file != null)
            //    {
            //        datastream = new MemoryStream();
            //        await file.CopyToAsync(datastream);
            //        user.ProfilePicture = datastream.ToArray();
            //    }
            //    await _userManager.UpdateAsync(user);
            //}
            if (Request.Form.Files.Count > 0)
            {
                IFormFile file = Request.Form.Files.FirstOrDefault();
                if (file != null)
                {
                    using (MemoryStream datastream = new MemoryStream())
                    {
                        await file.CopyToAsync(datastream);
                        user.ProfilePicture = datastream.ToArray();
                        datastream.Position = 0; // Reset position
                    }
                }

                await _userManager.UpdateAsync(user);
            }

              //return RedirectToAction("IndexPage", "Home");
            //if (user.UsernameChangeLimit > 0)
            //{
            //    if (Input.UserName != user.UserName)
            //    {
            //        var userNameExists = await _userManager.FindByNameAsync(Input.UserName);
            //        if (userNameExists != null)
            //        {
            //            StatusMessage = "User name already exists. Select a different username.";
            //            return RedirectToAction("Dashboard", "Home");
            //        }
            //    }
            //    var setUserName = await _userManager.SetUserNameAsync(user, Input.UserName);
            //    if (!setUserName.Succeeded)
            //    {
            //        StatusMessage = "Unexpected error when trying to set user name.";
            //        return RedirectToAction("Dashboard", "Home");
            //    }
            //    else
            //    {
            //        user.UsernameChangeLimit -= 1;
            //        await _userManager.UpdateAsync(user);
            //    }
            //}
            if (user != null)
            {
                if (user.UsernameChangeLimit > 0)
                {
                    if (Input.UserName != null && Input.UserName != user.UserName)
                    {
                        var userNameExists = await _userManager.FindByNameAsync(Input.UserName);
                        if (userNameExists != null)
                        {
                            StatusMessage = "User name already exists. Select a different username.";
                            return RedirectToAction("IndexPage", "Home");
                        }
                    }

                    var setUserName = await _userManager.SetUserNameAsync(user, Input.UserName);
                    if (!setUserName.Succeeded)
                    {
                        StatusMessage = "Unexpected error when trying to set user name.";
                        return RedirectToAction("IndexPage", "Home");
                    }
                    else
                    {
                        user.UsernameChangeLimit -= 1;
                        await _userManager.UpdateAsync(user);
                    }
                }
                else
                {
                    StatusMessage = "You have reached the username change limit.";
                    return RedirectToAction("Dashboard", "Home");
                }
            }
            else
            {
                StatusMessage = "User not found.";
                return RedirectToAction("Dashboard", "Home");
            }
            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                // Handle the case where the update failed (e.g., log the error or show a message to the user)
                // For example, you can set the StatusMessage and return the Page to show the error message.
                StatusMessage = "Failed to update profile.";
                return Page();
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
