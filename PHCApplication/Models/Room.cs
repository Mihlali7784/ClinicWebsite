using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Room number is required.")]
        [Display(Name = "Room Number")]
        [StringLength(20, ErrorMessage = "Room number should not exceed 20 characters.")]
        public string RoomNumber { get; set; }

        [Display(Name = "Description")]
        [StringLength(200, ErrorMessage = "Description should not exceed 200 characters.")]
        public string Description { get; set; }

       

        [Display(Name = "Capacity")]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive value.")]
        public int Capacity { get; set; }

        [Display(Name = "Is Available Now")]
        public bool IsAvailableNow { get; set; }

       

    }
}
