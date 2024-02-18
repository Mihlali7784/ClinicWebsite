
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using PHCApplication.Areas.Identity.Data;

//using PHCApplication.Areas.Identity.Data;

namespace PHCApplication.Models
{
    public class Patientss
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }



        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [StringLength(20, ErrorMessage = "Contact number should be between {2} and {1} characters.", MinimumLength = 5)]
        [RegularExpression(@"^[0-9+]+$", ErrorMessage = "Invalid contact number.")]
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100, ErrorMessage = "Address should be between {2} and {1} characters.", MinimumLength = 5)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Street Address is required.")]
        [StringLength(100, ErrorMessage = "Street Address should be between {2} and {1} characters.", MinimumLength = 5)]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Postal Address is required.")]
        [StringLength(10, ErrorMessage = "Postal Address should be between {2} and {1} characters.", MinimumLength = 5)]
        [Display(Name = "Postal Address")]
        public string PostalAddress { get; set; }

        [Required(ErrorMessage = "Marital status is required.")]
        [EnumDataType(typeof(MaritalStatus), ErrorMessage = "Invalid marital status.")]
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }


        [Required(ErrorMessage = "Username is required.")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Username should be between 4 and 20 characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [ForeignKey("ApplicationUser")]
        [Display(Name = "Admin")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
