using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Referral
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Referral date is required.")]
        [Display(Name = "Referral Date")]
        [DataType(DataType.Date)]
        public DateTime ReferralDate { get; set; }

       

        [Required(ErrorMessage = "Referred doctor/clinic is required.")]
        [Display(Name = "Referred Doctor/Clinic")]
        public string ReferredDoctorOrClinic { get; set; }

        [StringLength(500, ErrorMessage = "Reason for referral should not exceed 500 characters.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The Reason field can only contain letters.")]
        [Display(Name = "Reason for Referral")]
        public string ReasonForReferral { get; set; }

        
    }
            
}
