using System.ComponentModel.DataAnnotations;

namespace CMSApp.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }

        [Required]
        public string LecturerId { get; set; }  // Foreign key for User (Lecturer)

        [Required]
        public double HoursWorked { get; set; }

        [Required]
        public double HourlyRate { get; set; }

        public string Notes { get; set; } = "";

        public string Status { get; set; } = "Pending";  // Default status

        public DateTime SubmittedDate { get; set; } = DateTime.Now;

        // Navigation property to Documents
        public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
