using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Discharge
    {
        [Key]
        public int ID { get; set; }

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

        [Required(ErrorMessage = "Check In Date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Check In Date")]
        public DateTime CheckInDate { get; set; }


        [Required(ErrorMessage = "Check Out Date is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Check Out Date")]
        public DateTime CheckOutDate { get; set; }


        [Required(ErrorMessage = "Reason is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The Reason field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Reason must be between 2 and 50 characters")]
        public string Reason { get; set; }
    }
}
