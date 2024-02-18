using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Department name is required.")]
        [StringLength(100, ErrorMessage = "Department name should not exceed 100 characters.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description should not exceed 500 characters.")]
        public string Description { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [StringLength(20, ErrorMessage = "Contact number should be between {2} and {1} characters.", MinimumLength = 5)]
        [RegularExpression(@"^[0-9+]+$", ErrorMessage = "Invalid contact number.")]
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "  Location is required.")]
        [StringLength(100, ErrorMessage = "Location should be between {2} and {1} characters.", MinimumLength = 5)]
        public string Location { get; set; }

        
       


    }
}
