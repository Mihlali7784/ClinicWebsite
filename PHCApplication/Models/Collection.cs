using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Collection
    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Select Collection Type")]
        [Display(Name = "Collection Type")]
        public string CollectionType { get; set; }


    }
}
