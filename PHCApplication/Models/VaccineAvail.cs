using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class VaccineAvail
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string VaccName { get; set; }
        [Required]
        public int Available { get; set; }
    }
}
