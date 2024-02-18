using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Equipment name is required.")]
        [StringLength(100, ErrorMessage = "Equipment name should not exceed 100 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Description should not exceed 200 characters.")]
        public string Description { get; set; }

        [Display(Name = "Maintenance Date")]
        [DataType(DataType.Date)]
        public DateTime? LastMaintenanceDate { get; set; }

       
        [Display(Name = "Condition")]
        public EquipmentCondition Condition { get; set; }

        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }

       
    }
    public enum EquipmentCondition
    {
        New,
        Good,
        Fair,
        Poor
    }

}
