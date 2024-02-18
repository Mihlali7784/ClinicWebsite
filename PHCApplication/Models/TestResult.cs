using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class TestResult
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Test result value is required.")]
        [StringLength(100, ErrorMessage = "Test result value should not exceed 100 characters.")]
        public string Value { get; set; }

        [Display(Name = "Test Date")]
        [DataType(DataType.Date)]
        public DateTime TestDate { get; set; }

        [StringLength(500, ErrorMessage = "Comments should not exceed 500 characters.")]
        public string Comments { get; set; }

       
    }
}
