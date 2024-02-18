using System.ComponentModel.DataAnnotations;

namespace PHCApplication.Models
{
    public class RatingReview
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Review { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
