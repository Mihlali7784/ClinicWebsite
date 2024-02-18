using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHCApplication.Models
{
    public class Diagnose
    {
        [Key]
        public int DiagnoseId { get; set; }



        [Required(ErrorMessage = "Diagnose Date and Time is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Diagnose Time & Date")]
        public DateTime DiagnoseDateTime { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Treatment is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Treatment { get; set; }


        // Additional attributes for the Diagnose class

        [Required(ErrorMessage = "Medical Facility is required.")]
        [Display(Name = "Medical Facility")]
        public string MedicalFacility { get; set; }

        [Display(Name = "Follow-up Appointment")]
        [Required(ErrorMessage = "Diagnose Date and Time is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime FollowUpAppointment { get; set; }

        [Display(Name = "Medication Details")]
        [StringLength(200, ErrorMessage = "Medication details should not exceed 200 characters.")]
        public string MedicationDetails { get; set; }

        //Pass Cities Id as fk
        [ForeignKey("ApplicationUser")]
        [Display(Name = "Doctor")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


    }
}
