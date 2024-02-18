using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class OrderVacc
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string VaccType { get; set; }
        [Required]
        public int Quamtity { get; set; }
        [Required]
        public string StorageRequi { get; set; }
        [Required]

        public DateTime RequestDateTime { get; set; }
    }
}
