using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        [StringLength(100, ErrorMessage = "Supplier name should not exceed 100 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Address should not exceed 200 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid contact number.")]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
       
        
    }
}
