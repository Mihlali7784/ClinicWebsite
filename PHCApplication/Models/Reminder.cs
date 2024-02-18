using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHCApplication.Models
{
    public class Reminder
    {
        public int ReminderId { get; set; }

        [Required(ErrorMessage = "Reminder type is required.")]
        public string ReminderType { get; set; }

        [Required(ErrorMessage = "Reminder date and time are required.")]
        [DataType(DataType.DateTime)]
        public DateTime ReminderDate { get; set; }

        // Additional attributes
        [MaxLength(200, ErrorMessage = "Description should not exceed 200 characters.")]
        public string Description { get; set; }
        
        [Display(Name = "Is Completed")]
        public bool IsCompleted { get; set; }

        [Required(ErrorMessage = "Priority is required.")]
        [Range(1, 5, ErrorMessage = "Priority should be between 1 and 5.")]
        public int Priority { get; set; }

        [Display(Name = "Is Recurring")]
        [Required(ErrorMessage = "Is Recurring is required.")]
        public bool IsRecurring { get; set; }

        [MaxLength(100, ErrorMessage = "Location should not exceed 100 characters.")]
        public string Location { get; set; }

        //Pass Cities Id as fk
        [ForeignKey("ApplicationUser")]
        [Display(Name = "Patient")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
