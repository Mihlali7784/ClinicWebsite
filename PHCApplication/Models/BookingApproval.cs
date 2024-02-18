using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class BookingApproval
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Doctor's name is required.")]
        public string DoctorName { get; set; }

        [Required(ErrorMessage = "Patient's name is required.")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Appointment date is required.")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required(ErrorMessage = "Appointment time is required.")]
        [DataType(DataType.Time)]
        public DateTime AppointmentTime { get; set; }

        [Required(ErrorMessage = "Appointment type is required.")]
        public string AppointmentType { get; set; }

        [Required(ErrorMessage = "Reason for booking is required.")]
        public string BookingReason { get; set; }

        [Required(ErrorMessage = "Additional notes are required.")]
        public string AdditionalNotes { get; set; }

        public bool IsApproved { get; set; }

        public string ApprovalComments { get; set; }

        public DateTime ApprovalDate { get; set; }
    }
}
