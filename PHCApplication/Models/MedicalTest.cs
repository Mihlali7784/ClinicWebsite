using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class MedicalTest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Test name is required.")]
        [StringLength(100, ErrorMessage = "Test name should not exceed 100 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Description should not exceed 200 characters.")]
        public string Description { get; set; }

        [Display(Name = "Reference Range")]
        [StringLength(100, ErrorMessage = "Reference range should not exceed 100 characters.")]
        public string ReferenceRange { get; set; }

        [StringLength(50, ErrorMessage = "Units should not exceed 50 characters.")]
        public string Units { get; set; }

    }
}
