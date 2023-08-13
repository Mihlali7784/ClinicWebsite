using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

namespace PHCApplication.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class

public enum Gender
{
    Male,
    Female,
}
public enum MaritalStatus
{
    Single,
    Married,
    Divorced,
    Widowed,
    Other
}
public enum UserRole
{
    Doctor,
    Patient,
    Pharmacist,
    Administrator
}
public class ApplicationUser : IdentityUser
{

    [Required(ErrorMessage = "Registration date and time is required.")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
    public DateTime RegistrationDateTime { get; set; }


    //[PersonalData]
    //[Column(TypeName = "nvarchar(100)")]
    //public string FirstName { get; set; }
    [Required(ErrorMessage = "First name is required.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }


    //[PersonalData]
    //[Column(TypeName = "nvarchar(100)")]
    //public string LastName { get; set; }
    [Required(ErrorMessage = "Last name is required.")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    //[PersonalData]
    //[Column(TypeName = "nvarchar(10)")]
    //public string Gender { get; set; }
    [Required(ErrorMessage = "Gender is required.")]
    [EnumDataType(typeof(Gender), ErrorMessage = "Invalid gender.")]
    public Gender Gender { get; set; }

    //[PersonalData]
    //[Column(TypeName = "date")]
    [Required(ErrorMessage = "Date of Birth is required.")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Date of Birth")]
    public DateTime DateOfBirth { get; set; }


    [Required(ErrorMessage = "Address is required.")]
    [StringLength(100, ErrorMessage = "Address should be between {2} and {1} characters.", MinimumLength = 5)]
    public string Address { get; set; }


    [Required(ErrorMessage = "Street address is required.")]
    [StringLength(100, ErrorMessage = "Street Address should be between {2} and {1} characters.", MinimumLength = 5)]
    [Display(Name = "Street Address")]
    public string StreetAddress { get; set; }


    [StringLength(50, ErrorMessage = "City should be between {2} and {1} characters.", MinimumLength = 2)]
    [Required(ErrorMessage = "City is required.")]
    public string City { get; set; }

    [Required(ErrorMessage = "Postal address is required.")]
    [StringLength(10, ErrorMessage = "Postal Address should be between {2} and {1} characters.", MinimumLength = 5)]
    [Display(Name = "Postal Address")]
    public string PostalAddress { get; set; }


    [Required(ErrorMessage = "Marital status is required.")]
    [EnumDataType(typeof(MaritalStatus), ErrorMessage = "Invalid marital status.")]
    [Display(Name = "Marital Status")]
    public MaritalStatus MaritalStatus { get; set; }



    [Required(ErrorMessage = "Contact number is required.")]
    [StringLength(20, ErrorMessage = "Contact number should be between {2} and {1} characters.", MinimumLength = 5)]
    [RegularExpression(@"^[0-9+]+$", ErrorMessage = "Invalid contact number.")]
    [Phone]
    [Display(Name = "Contact Number")]
    public string ContactNumber { get; set; }

    //[PersonalData]
    //[Column(TypeName = "nvarchar(20)")]
    //public string Role { get; set; }

    [Required(ErrorMessage = "Role is required.")]
    [EnumDataType(typeof(UserRole), ErrorMessage = "Invalid role.")]
    public UserRole Role { get; set; }
    public int UsernameChangeLimit { get; set; } = 10;
    public byte[]? ProfilePicture { get; set; }

}

