using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Pharmacy
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Pharmacy name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Pharmacy must be between 2 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Street Address is required.")]
        [StringLength(500, ErrorMessage = "Address should not exceed 500 characters.")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Street Address is required.")]
        [StringLength(100, ErrorMessage = "Street Address should be between {2} and {1} characters.", MinimumLength = 5)]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Display(Name = "Operating Hours")]
        public OperatingHours OperatingHours { get; set; }

        
    }
    public enum OperatingHours
    {
        [Display(Name = "9:00 AM - 6:00 PM")]
        Monday,
        [Display(Name = "9:00 AM - 6:00 PM")]
        Tuesday,
        [Display(Name = "9:00 AM - 6:00 PM")]
        Wednesday,
        [Display(Name = "9:00 AM - 6:00 PM")]
        Thursday,
        [Display(Name = "9:00 AM - 6:00 PM")]
        Friday,
        [Display(Name = "9:00 AM - 1:00 PM")]
        Saturday,
        ClosedSunday
    }
}
