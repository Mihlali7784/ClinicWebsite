using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace PHCApplication.Models
{
    public class Walk_in
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


        [Required(ErrorMessage = "Appointment date and time are required.")]
        [Display(Name = "Date and Time")]
        [DataType(DataType.DateTime)]
        [FutureDate(ErrorMessage = "Appointment date must be in the future.")]
        public DateTime DateTime { get; set; }


        [StringLength(200, ErrorMessage = "SubSystem is required.")]
        public string Specialisation { get; set; }


        [StringLength(200, ErrorMessage = "Description should not exceed 200 characters.")]
        public string Description { get; set; }

    }
}
