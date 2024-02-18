using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class GenCert
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string DrName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        public DateTime VaccDate { get; set; }
        [Required]
        public string VaccinationType { get; set; }
        [Required]
        public string Site { get; set; }
    }
}
