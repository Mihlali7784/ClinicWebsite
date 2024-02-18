using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace PHCApplication.Models
{
    public class PrenatalPatientReg
    {
        [Key]
        [Display(Name = "Patient Number")]
        public int PatientID { get; set; }

        [SouthAfricanIDNumber]
        [Display(Name = "South African ID Number")]
        public string IDNumber { get; set; }

        [Required(ErrorMessage = "Please enter the patient's first name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the patient's last name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [SouthAfricanIDNumber]
        [Required(ErrorMessage = "Please enter the patient's date of birth.")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [SouthAfricanIDNumber]
        [Required(ErrorMessage = "Please choose gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter the patient's address.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the patient's phone number.")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter the patient's email address.")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Preferred Language")]
        public string PreferredLanguage { get; set; }

        // Additional properties as needed for prenatal care registration

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Display(Name = "Blood Type")]
        public string BloodType { get; set; }

        [Display(Name = "Emergency Contact Name")]
        public string EmergencyContactName { get; set; }

        public string Password { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class SouthAfricanIDNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string idNumber = value.ToString();

                // Ensure the ID number is 13 characters long
                if (idNumber.Length != 13)
                {
                    return new ValidationResult("South African ID number must be 13 characters long.");
                }

                // Check that the ID number consists of numeric digits
                if (!Regex.IsMatch(idNumber, @"^\d+$"))
                {
                    return new ValidationResult("South African ID number should contain only numeric digits.");
                }

                // Perform additional validation logic, such as date of birth, gender, and checksum validation

                // Implement your specific validation logic here

                // If the ID number is valid, return ValidationResult.Success
                return ValidationResult.Success;
            }

            // If the value is null, assume it's not a valid ID number
            return new ValidationResult("South African ID number is required.");
        }

        // Perform additional validation logic, such as date of birth, gender, and checksum validation
        private ValidationResult ValidateIDNumber(string idNumber)
        {
            // Verify that the ID number starts with a valid date of birth
            if (!VerifyDateOfBirth(idNumber))
            {
                return new ValidationResult("Invalid date of birth in the South African ID number.");
            }

            // Verify that the gender portion is valid
            if (!VerifyGender(idNumber))
            {
                return new ValidationResult("Invalid gender in the South African ID number.");
            }

            // Perform checksum validation
            if (!VerifyChecksum(idNumber))
            {
                return new ValidationResult("Invalid South African ID number checksum.");
            }

            return ValidationResult.Success;
        }

        // Validate date of birth
        private bool VerifyDateOfBirth(string idNumber)
        {
            // Extract the date of birth from the ID number
            string dob = idNumber.Substring(0, 6);
            int year = int.Parse(dob.Substring(0, 2));
            int month = int.Parse(dob.Substring(2, 2));
            int day = int.Parse(dob.Substring(4, 2));

            // Ensure that the month is between 01 and 12
            if (month < 1 || month > 12)
            {
                return false;
            }

            // Perform specific validations for the year, considering two-digit year representation
            // In this example, we assume that valid years are between 01 and 99
            int currentYear = DateTime.Now.Year % 100; // Get the last two digits of the current year
            if (year < 1 || year > currentYear)
            {
                return false;
            }

            // Verify that the day is valid based on the month (taking leap years into account)
            if (day < 1 || day > DateTime.DaysInMonth(2000 + year, month))
            {
                return false;
            }

            // You can add more specific checks, such as verifying that the date is not in the future or too far in the past

            // Example: Ensure the date is not in the future
            DateTime currentDate = DateTime.Now;
            DateTime dateOfBirth = new DateTime(2000 + year, month, day);
            if (dateOfBirth > currentDate)
            {
                return false;
            }

            // Example: Ensure the date is not too far in the past
            DateTime earliestValidDate = DateTime.Now.AddYears(-100); // Considering a reasonable range
            if (dateOfBirth < earliestValidDate)
            {
                return false;
            }

            return true;
        }

        // Validate gender
        private bool VerifyGender(string idNumber)
        {
            // Extract the gender digit from the ID number
            int genderDigit = int.Parse(idNumber.Substring(6, 1));

            // Verify that the gender digit corresponds to a valid gender code
            bool isValidGender = (genderDigit % 2 == 0); // Even gender digit represents females, odd represents males

            // You can return true if the gender is valid or false if it's not

            return isValidGender;
        }

        // Perform checksum validation
        private bool VerifyChecksum(string idNumber)
        {
            // Implement your specific checksum validation logic here

            return true;
        }

    }
}

