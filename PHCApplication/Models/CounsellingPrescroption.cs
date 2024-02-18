using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class CounsellingPrescroption
    {
        [Key]
        public int PrescroptionId { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "Patient")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "Prescroption")]
        public string Note { get; set; }

        [Required]
        [Display(Name = "Desicription")]
        public string Desc { get; set; }

    }
}
