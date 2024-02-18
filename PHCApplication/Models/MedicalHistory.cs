using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class MedicalHistory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "Patient")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "History of Mental Health Treatment")]
        public string HistoryMentalHealthTreatment { get; set; }

        [Required]
        [Display(Name = "Current of Mental Health Treatment")]
        public string CurrentMentalHealthTreatment { get; set; }

        [Required]
        [Display(Name = "Substance Use History")]
        public string Substance { get; set; }

        [Required]
        [Display(Name = "Next Treatment")]
        public string Date { get; set; }
    }
}
