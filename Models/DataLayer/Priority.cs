using System.ComponentModel.DataAnnotations;

namespace CallTrak_System.Models.DataLayer
{
    public class Priority
    {
        public int PriorityId { get; set; }

        [Required(ErrorMessage = "Please enter priority description.")]
        public string? Description { get; set; }
    }
}
