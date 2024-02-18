using PHCApplication.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHCApplication.Models
{
    public class Discharge
    {
        [Key]
        public int DischargeId { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Discharge date is required.")]
        [Display(Name = "Check in Date")]
        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }

        [Required(ErrorMessage = "Discharge date is required.")]
        [Display(Name = "Discharge Date")]
        [DataType(DataType.Date)]
        public DateTime DischargeDate { get; set; }

        [Required(ErrorMessage = "Room is required")]
        public string Room { get; set; }

        [Required(ErrorMessage = "Appointment status is required.")]
        public string Status { get; set; }

        [StringLength(500, ErrorMessage = "Discharge summary should not exceed 500 characters.")]
        [Display(Name = "Discharge Summary")]
        public string Summary { get; set; }

        //Pass Cities Id as fk
        [ForeignKey("ApplicationUser")]
        [Display(Name = "Patient")]
        public string UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }



    }
}

