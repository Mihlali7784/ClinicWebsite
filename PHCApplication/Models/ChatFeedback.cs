using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class ChatFeedback
    {
        [Key]
        public int ChatFeedbackId { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Doctor's Name")]
        public string DoctorName { get; set; }

        [Required(ErrorMessage = "Feedback is required.")]
        [StringLength(500, ErrorMessage = "Feedback should not exceed 500 characters.")]
        [Display(Name = "Feedback")]
        public string Feedback { get; set; }

        [Required(ErrorMessage = "Please provide a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        [Display(Name = "Ratings")]
        public int Rating { get; set; }

        // New attributes and their validations for ChatFeedback
        [Required(ErrorMessage = "Wait time is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Wait time must be a positive value.")]
        [Display(Name = "Wait Time (minutes)")]
        public int WaitTimeInMinutes { get; set; }
        [Required(ErrorMessage = "Treatment effectiveness is required.")]
        [Range(1, 5, ErrorMessage = "Treatment effectiveness must be between 1 and 5.")]
        [Display(Name = "Treatment Effectiveness")]
        public string TreatmentEffectiveness { get; set; }
        [Required(ErrorMessage = "Communication clarity is required.")]
        [Range(1, 5, ErrorMessage = "Communication clarity must be between 1 and 5.")]
        [Display(Name = "Communication Clarity")]
        public string CommunicationClarity { get; set; }

        [Required(ErrorMessage = "Ease of appointment is required.")]
        [Range(1, 5, ErrorMessage = "Ease of appointment must be between 1 and 5.")]
        [Display(Name = "Ease of Appointment")]
        public string EaseOfAppointment { get; set; }
        [Required(ErrorMessage = "Satisfaction with experience is required.")]
        [Range(1, 5, ErrorMessage = "Satisfaction with experience must be between 1 and 5.")]
        [Display(Name = "Satisfaction with Experience")]
        public string SatisfactionWithExperience { get; set; }

        //for Doctor 
        [Required(ErrorMessage = "Communication Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Communication Date")]
        public DateTime CommunicationDate { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Subject must be between 5 and 100 characters")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Communication Rating is required.")]
        [Range(1, 5, ErrorMessage = "Communication Rating must be between 1 and 5")]
        [Display(Name = "Communication Rating")]
        public int CommunicationRating { get; set; }

        [Required(ErrorMessage = "Response Time is required.")]
        [Range(1, 60, ErrorMessage = "Response Time must be between 1 and 60 minutes")]
        [Display(Name = "Response Time (minutes)")]
        public int ResponseTimeInMinutes { get; set; }

        //Pass Cities Id as fk
        [ForeignKey("ApplicationUser")]
        [Display(Name = "User")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
