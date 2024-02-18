using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PHCApplication.Models
{
    public class Reports
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Report name is required.")]
        [StringLength(100, ErrorMessage = "Report name should not exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Report type is required.")]
        [Display(Name = "Report Type")]
        public ReportType Type { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Report Date")]
        public DateTime ReportDate { get; set; }

        [StringLength(500, ErrorMessage = "Description should not exceed 500 characters.")]
        public string Description { get; set; }

       

        [Display(Name = "Report Content")]
        public byte[] Content { get; set; }

        [Display(Name = "Report Status")]
        public ReportStatus Status { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Username should be between 4 and 20 characters.")]
        public string Username { get; set; }

        [StringLength(500, ErrorMessage = "Comments should not exceed 500 characters.")]
        public string Comments { get; set; }

        [Display(Name = "File Format")]
        public FileFormat Format { get; set; }

       
    }
    public enum ReportType
    {
        Radiology,
        Laboratory,
        Pathology,
        Imaging,
        Consultation,
        Other
    }
    public enum ReportStatus
    {
        Pending,
        Reviewed,
        Finalized,
        Rejected
    }
    public enum FileFormat
    {
        PDF,
        DOCX,
        XLSX,
        JPG,
        PNG,
        Other
    }
}
