using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Procedure
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Select Room Type")]
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
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Equipment { get; set; }

    }
}
