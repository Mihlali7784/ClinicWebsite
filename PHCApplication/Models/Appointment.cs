using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Appointment
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

       
        [StringLength(200, ErrorMessage = "Notes should not exceed 200 characters.")]
        public string Notes { get; set; }

        

        [Required(ErrorMessage = "Appointment status is required.")]
        public AppointmentStatus Status { get; set; }

        
    }
    public enum AppointmentStatus
    {
        Schedule,
        Completed,
        Canceled
    }

    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var date = (DateTime)value;
            return date > DateTime.Now;
        }
    }

    
}
