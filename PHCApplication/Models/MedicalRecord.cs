using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class MedicalRecord
    {
        [Key]
        public int Id { get; set; }

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

        [Required(ErrorMessage = "Record creation date is required.")]
        [Display(Name = "Record Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [StringLength(500, ErrorMessage = "Medical history should not exceed 500 characters.")]
        [Display(Name = "Medical History")]
        public string MedicalHistory { get; set; }

        [StringLength(500, ErrorMessage = "Current medications should not exceed 500 characters.")]
        [Display(Name = "Current Medications")]
        public string CurrentMedications { get; set; }

        [StringLength(500, ErrorMessage = "Allergies should not exceed 500 characters.")]
        public string Allergies { get; set; }

        [Required(ErrorMessage = "Treatment is required.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        public string Treatment { get; set; }


        [Display(Name = "Blood Type")]
        public BloodType BloodType { get; set; }

        [Display(Name = "Height (cm)")]
        public double Height { get; set; }

        [Display(Name = "Weight (kg)")]
        public double Weight { get; set; }

        [Display(Name = "Smoking Habit")]
        public SmokingHabit SmokingHabit { get; set; }

        [Display(Name = "Alcohol Consumption")]
        public AlcoholConsumption AlcoholConsumption { get; set; }



      
       
    }
    public enum BloodType
    {
        APositive,
        ANegative,
        BPositive,
        BNegative,
        ABPositive,
        ABNegative,
        OPositive,
        ONegative
    }

    public enum SmokingHabit
    {
        NonSmoker,
        FormerSmoker,
        CurrentSmoker
    }

    public enum AlcoholConsumption
    {
        NonDrinker,
        OccasionalDrinker,
        RegularDrinker
    }
}
