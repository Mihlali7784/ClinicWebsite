using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class Appointment
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "Please Select Appointment tYPE")]
        [Display(Name = "Appointment Type")]
        public string AppointmentType { get; set; }

        [Required(ErrorMessage = "date and time is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date and Time")]
        public DateTime dateTime { get; set; }

         [Required(ErrorMessage = "Please Select Doctor Type")]
        [Display(Name = "Doctor Type")]
        public string DoctorType { get; set; }
    }
}
