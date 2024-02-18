using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using PHCApplication.Areas.Identity.Data;

namespace PHCApplication.Models
{
    public class Examination
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DoctorName { get; set; }

        [Required]
        public string PatientName { get; set; }

        [Required]
        public string PatientLastName { get; set; }

        [Required(ErrorMessage = "Patient ID number is required.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Patient ID number must be numeric.")]
        [Display(Name = "Patient ID Number")]
        public string PatientIdNumber { get; set; }

        [Required]
        public string BloodType { get; set; }

        [Required]
        public string Symptoms { get; set; }

        [Required]
        public string Diagnose { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "Doctor")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}
