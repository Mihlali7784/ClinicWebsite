using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class Appoint
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string VaccinationType { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfVaccination { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [StringLength(20, ErrorMessage = "Contact number should be between {2} and {1} characters.", MinimumLength = 5)]
        [RegularExpression(@"^[0-9+]+$", ErrorMessage = "Invalid contact number.")]
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
    }
}
