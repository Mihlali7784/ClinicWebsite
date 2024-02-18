using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Collection
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Collection date and time are required.")]
        [Display(Name = "Date and Time")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        
        [Required(ErrorMessage = "Medicine name is required.")]
        [StringLength(100, ErrorMessage = "Medicine name should not exceed 100 characters.")]
        public string MedicineName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get; set; }

        [StringLength(200, ErrorMessage = "Notes should not exceed 200 characters.")]
        public string Notes { get; set; }

        

    }
}
