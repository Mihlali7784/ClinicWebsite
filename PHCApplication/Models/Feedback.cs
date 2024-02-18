using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Doctor's name is required.")]
        public string DoctorName { get; set; }

        [Required(ErrorMessage = "Patient's name is required.")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Feedback type is required.")]
        public string FeedbackType { get; set; }

        public bool IsAnonymous { get; set; }
    }
}
