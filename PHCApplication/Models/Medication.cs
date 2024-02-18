using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Medication
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Medication name is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Dosage is required.")]
        [StringLength(50, ErrorMessage = "Dosage should not exceed 50 characters.")]
        public string Dosage { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Prescription Date")]
        public DateTime PrescriptionDate { get; set; }

        [Required(ErrorMessage = "Treatment is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Treatment { get; set; }

       
        [Required(ErrorMessage = "Patient is required.")]
        [Display(Name = "Patient")]
        public int PharmacistId { get; set; }

        [Display(Name = "Dosage Frequency")]
        public DosageFrequency DosageFrequency { get; set; }

        [StringLength(200, ErrorMessage = "Notes should not exceed 200 characters.")]
        public string Notes { get; set; }
        


    }
    public enum DosageFrequency
    {
        OncePerDay,
        TwicePerDay,
        ThreeTimesPerDay,
        FourTimesPerDay,
        AsNeeded
    }
}
