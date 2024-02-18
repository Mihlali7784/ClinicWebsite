using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class ReferralsCounselling
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "Patient")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


        [Required]
        [Display(Name = " Referral Date")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Are you currently in any Medication")]
        public string Medication { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Desc { get; set; }
    }
}
