using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

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

        [Required(ErrorMessage = "Specialty is required.")]
        [StringLength(50, ErrorMessage = "Specialty should not exceed 50 characters.")]
        public string Specialty { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100, ErrorMessage = "Address should be between {2} and {1} characters.", MinimumLength = 5)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Marital status is required.")]
        [EnumDataType(typeof(MaritalStatus), ErrorMessage = "Invalid marital status.")]
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number.")]
        public string ContactNumber { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "License number is required.")]
        [StringLength(20, ErrorMessage = "License number should not exceed 20 characters.")]
        [Display(Name = "License Number")]
        public string LicenseNumber { get; set; }

        [Range(1, 50, ErrorMessage = "Years of experience must be between 1 and 50.")]
        [Display(Name = "Years of Experience")]
        public int YearsOfExperience { get; set; }


        


        //[Required(ErrorMessage = "Username is required.")]
        //[StringLength(20, MinimumLength = 4, ErrorMessage = "Username should be between 4 and 20 characters.")]
        //public string Username { get; set; }

        //[Required(ErrorMessage = "Password is required.")]
        //[DataType(DataType.Password)]
        //[StringLength(20, MinimumLength = 6, ErrorMessage = "Password should be between 6 and 20 characters.")]
        //public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Passwords do not match.")]
        //[DataType(DataType.Password)]
        //public string ConfirmPassword { get; set; }

        public class AgeRangeAttribute : ValidationAttribute
        {
            private readonly int _minAge;
            private readonly int _maxAge;

            public AgeRangeAttribute(int minAge, int maxAge)
            {
                _minAge = minAge;
                _maxAge = maxAge;
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var dateOfBirth = (DateTime)value;
                var age = DateTime.Today.Year - dateOfBirth.Year;

                if (DateTime.Today < dateOfBirth.AddYears(age))
                {
                    age--;
                }

                if (age < _minAge || age > _maxAge)
                {
                    return new ValidationResult($"Age must be between {_minAge} and {_maxAge} years.");
                }

                return ValidationResult.Success;
            }



        }
    }
}

