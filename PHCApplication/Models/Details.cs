using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models

{
    public class Details
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100, ErrorMessage = "Address should be between {2} and {1} characters.", MinimumLength = 5)]
        public string Address { get; set; }


        [Required(ErrorMessage = "Street Address is required.")]
        [StringLength(100, ErrorMessage = "Street Address should be between {2} and {1} characters.", MinimumLength = 5)]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(50, ErrorMessage = "City should be between {2} and {1} characters.", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal Address is required.")]
        [StringLength(10, ErrorMessage = "Postal Address should be between {2} and {1} characters.", MinimumLength = 5)]
        [Display(Name = "Postal Address")]
        public string PostalAddress { get; set; }

        [Required(ErrorMessage = "Vaccination Type is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string VaccinationType { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [StringLength(20, ErrorMessage = "Contact number should be between {2} and {1} characters.", MinimumLength = 5)]
        [RegularExpression(@"^[0-9+]+$", ErrorMessage = "Invalid contact number.")]
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }


        [Required(ErrorMessage = "Date of Vaccination is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfVaccination { get; set; }

        [Display(Name = "Underlying Health Conditions")]
        public string UUnderlyingHealthConditions { get; set; }

        [Display(Name = "Allergies")]
        public string Allergies { get; set; }

        [Display(Name = "Current Medications")]
        public string CurrentMedications { get; set; }

        [Display(Name = "Previous Vaccination History")]
        public string PreviousVaccinationHistory { get; set; }
    }
}
