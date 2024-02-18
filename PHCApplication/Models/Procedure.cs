using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHCApplication.Models
{
    public class Procedure
    {
        [Key]
        public int ProcedureId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "Procedure Name")]
        public string ProcedureName { get; set; }

        [Required(ErrorMessage = "Procedure Type is required.")]
        [Display(Name = "Procedure Type")]
        public string ProcedureType { get; set; }

        [Required(ErrorMessage = "Procedure Date and Time is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Procedure Time & Date")]
        public DateTime ProcedureDateTime { get; set; }


        [Required(ErrorMessage = "Description is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Equipment is required.")]
        public string Equipment { get; set; }

        [Required(ErrorMessage = "Duration is required.")]
        [Display(Name = "Duration (minutes)")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive value.")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Room Number is required.")]
        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }


        [Range(typeof(bool), "true", "true", ErrorMessage = "The Terms and Conditions must be accepted.")]
        [Display(Name = "Terms and Conditions")]
        public bool TermsAndConditions { get; set; }

        //Pass Cities Id as fk
        [ForeignKey("ApplicationUser")]
        [Display(Name = "Doctor")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }




    }
}
