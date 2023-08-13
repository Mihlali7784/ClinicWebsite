using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class TestResult
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Date and Time is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created Time & Date")]
        public DateTime CreatedDateTime { get; set; }

        [Required(ErrorMessage = "Please Select Test Result Type")]
        [Display(Name = "Test Result Type")]
        public string TestResultType { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "Diagnose Name")]
        public string DiagnoseName { get; set; }


    }
}
