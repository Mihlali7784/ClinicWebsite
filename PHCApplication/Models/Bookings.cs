using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class Bookings
    {
        [Key]
        public int BookingsId { get; set; }
        [Required(ErrorMessage = "Appointment date and time are required.")]
        [Display(Name = "Booking Date")]
        [DataType(DataType.DateTime)]
        [FutureDate(ErrorMessage = "Appointment date must be in the future.")]
        public DateTime BookingDate { get; set; }
        [Required(ErrorMessage = "Appointment date and time are required.")]
        [Display(Name = "Start Date & Time")]
        [DataType(DataType.DateTime)]
        [FutureDate(ErrorMessage = "Appointment date must be in the future.")]
        public DateTime StartDateTime { get; set; }
        [Required(ErrorMessage = "Appointment date and time are required.")]
        [Display(Name = "End Date & Time")]
        [DataType(DataType.DateTime)]
        [FutureDate(ErrorMessage = "Appointment date must be in the future.")]
        public DateTime EndDateTime { get; set; }

        [Required(ErrorMessage = "Service Type is required.")]
        [RegularExpression("^(Medical Procedure|Check-up|Blood Donation)$", ErrorMessage = "Invalid Service Type.")]
        [Display(Name = "Service Type")]
        public string ServiceType { get; set; }
        [Required(ErrorMessage = "Status is required.")]
        [RegularExpression("^(Pending|Completed|In Progress)$", ErrorMessage = "Invalid Status.")]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [StringLength(200, ErrorMessage = "Notes should not exceed 200 characters.")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "Duration is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive value.")]
        [Display(Name = "Duration (minutes)")]
        public int DurationInMinutes { get; set; }

        [Display(Name = "Additional Details")]
        [StringLength(500, ErrorMessage = "Additional details should not exceed 500 characters.")]
        public string AdditionalDetails { get; set; }

        [Required]
        [Display(Name = "Terms and Conditions")]
        public bool TermsAndConditions { get; set; }

        //Pass Cities Id as fk
        [ForeignKey("ApplicationUser")]
        [Display(Name = "User")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
