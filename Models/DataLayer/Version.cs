using System.ComponentModel.DataAnnotations;

namespace CallTrak_System.Models.DataLayer
{
    public class Version
    {
        public int VersionId { get; set; }

        [Required(ErrorMessage = "Please enter version description.")]
        public string? Description { get; set; }
    }
}
