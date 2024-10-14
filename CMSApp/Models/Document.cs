using System.ComponentModel.DataAnnotations;

namespace CMSApp.Models
{
    public class Document
    {
        [Key]
        public int DocumentId { get; set; }

        [Required]
        public int ClaimId { get; set; }  // Foreign key for Claim

        [Required]
        public string FilePath { get; set; } = "";

        [Required]
        public string FileType { get; set; } = "";  // e.g., PDF, Word, etc.

        // Navigation property to Claim
        public virtual Claim Claim { get; set; }
    }
}
