using System.ComponentModel.DataAnnotations;

namespace CallTrak_System.Models.DataLayer
{
    public class Module
    {
        public int ModuleId { get; set; }

        [Required(ErrorMessage = "Please enter module description.")]
        public string? Description { get; set; }
    }
}
