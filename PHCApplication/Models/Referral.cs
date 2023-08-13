using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Referral
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Select Referral Type")]
        [Display(Name = "Referral Type")]
        public string ReferralType { get; set; }

        [Required(ErrorMessage = "Reason is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The Reason field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Reason must be between 2 and 50 characters")]
        public string Reason { get; set; }
    }
            
}
