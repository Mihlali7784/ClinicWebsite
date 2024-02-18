using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class ReportEvent
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Event { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
