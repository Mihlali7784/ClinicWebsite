using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class MedicalProcedureFile
    {
        [Key]
        public int MedicalProcedureFileId { get; set; }


        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Medical Procedure Type is required.")]
        [Display(Name = "Medical Procedure Type")]
        public string MedicalProcedure { get; set; }

        [Required(ErrorMessage = "Body Part is required.")]
        [Display(Name = "classification procedure")]
        public string Part { get; set; }

        [Required(ErrorMessage = "Room Number is required.")]
        [Display(Name = "Room Number")]
        public string Room { get; set; }

        [StringLength(200, ErrorMessage = "Description should not exceed 200 characters.")]
        [Display(Name = "Description")]
        public string Desc { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [RegularExpression("^(Pending|Completed|In Progress)$", ErrorMessage = "Invalid status. Must be 'Pending', 'Completed', or 'In Progress'.")]
        public string status { get; set; }

        [Required(ErrorMessage = "Weight is required.")]
        [Range(1, 500, ErrorMessage = "Invalid Weight.")]
        [Display(Name = "Weight (in kg)")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Height is required.")]
        [Range(1, 300, ErrorMessage = "Invalid Height.")]
        [Display(Name = "Height (in cm)")]
        public double Height { get; set; }

        [Display(Name = "Symptoms")]
        public string Symptoms { get; set; }

        [StringLength(500, ErrorMessage = "Current medications should not exceed 500 characters.")]
        [Display(Name = "Current Medications")]
        public string CurrentMedications { get; set; }

        [StringLength(500, ErrorMessage = "Allergies should not exceed 500 characters.")]
        public string Allergies { get; set; }

        [Required(ErrorMessage = "Treatment selection is required.")]
        [Display(Name = "Treatment")]
        public bool Treatment { get; set; }

        [Required(ErrorMessage = "Blood Type is required.")]
        [RegularExpression("^(A|B|AB)$", ErrorMessage = "Invalid Blood Type.")]
        [Display(Name = "Blood Type")]
        public string BloodType { get; set; }


        [Required(ErrorMessage = "Smoking Habit is required.")]
        [RegularExpression("^(frequently|none|normal)$", ErrorMessage = "Invalid Smoking Habit.")]
        [Display(Name = "Smoking Habit")]
        public string SmokingHabit { get; set; }

        [Required(ErrorMessage = "Alcohol Consumption is required.")]
        [RegularExpression("^(Yes|No|Occasional)$", ErrorMessage = "Invalid Alcohol Consumption.")]
        [Display(Name = "Alcohol Consumption")]
        public string AlcoholConsumption { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "User")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
