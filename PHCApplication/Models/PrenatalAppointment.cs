using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PHCApplication.Models
{
	public class PrenatalAppointment
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

		[Required(ErrorMessage = "Visit Type is required.")]
		[Display(Name = "Last Name")]
		public string preVisitType { get; set; }

		[Required(ErrorMessage = "Appointment date and time are required.")]
		[Display(Name = "Date and Time")]
		[DataType(DataType.DateTime)]
		[FutureDate(ErrorMessage = "Appointment date must be in the future.")]
		public DateTime DateTime { get; set; }


		[StringLength(200, ErrorMessage = "Notes should not exceed 200 characters.")]
		public string Notes { get; set; }



		[Required(ErrorMessage = "Appointment status is required.")]
		public AppointmentStatus Status { get; set; }

		[Required(ErrorMessage = "Description is required.")]
		[RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Description is required.")]
		[RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Date of Birth is required.")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Date of Birth")]
		public DateTime DateOfBirth { get; set; }

		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Address is required.")]
		[StringLength(100, ErrorMessage = "Address should be between {2} and {1} characters.", MinimumLength = 5)]
		public string Address { get; set; }


		[Required(ErrorMessage = "Street Address is required.")]
		[StringLength(100, ErrorMessage = "Street Address should be between {2} and {1} characters.", MinimumLength = 5)]
		[Display(Name = "Street Address")]
		public string StreetAddress { get; set; }

		[Required(ErrorMessage = "City is required.")]
		[StringLength(50, ErrorMessage = "City should be between {2} and {1} characters.", MinimumLength = 2)]
		public string City { get; set; }

		[Required(ErrorMessage = "Postal Address is required.")]
		[StringLength(10, ErrorMessage = "Postal Address should be between {2} and {1} characters.", MinimumLength = 5)]
		[Display(Name = "Postal Address")]
		public string PostalAddress { get; set; }

		[Required(ErrorMessage = "Vaccination Type is required.")]
		[RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "The name field can only contain letters.")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
		public string VaccinationType { get; set; }

		[Required(ErrorMessage = "Contact number is required.")]
		[StringLength(20, ErrorMessage = "Contact number should be between {2} and {1} characters.", MinimumLength = 5)]
		[RegularExpression(@"^[0-9+]+$", ErrorMessage = "Invalid contact number.")]
		[Phone]
		[Display(Name = "Contact Number")]
		public string ContactNumber { get; set; }

		[Display(Name = "Reason For Appointment")]
		public string Problem { get; set; }

		[Display(Name = "Identity Number")]
		public string IdentityNO { get; set; }
	}
//	public enum AppointmentStatus
//	{
//		Scheduled,
//		Completed,
//		Canceled
//	}

//	public class FutureDateAttribute : ValidationAttribute
//	{
//		public override bool IsValid(object value)
//		{
//			var date = (DateTime)value;
//			return date > DateTime.Now;
//		}
//	}
}

