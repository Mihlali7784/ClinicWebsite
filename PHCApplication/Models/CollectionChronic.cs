using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class CollectionChronic
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        [Display(Name = "Patient")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "Collection Date")]
        public string CollectionDate { get; set; }

        [Display(Name = "Description")]
        public string Desc { get; set; }

        public string status { get; set; }
    }
}
