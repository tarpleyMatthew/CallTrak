using System.ComponentModel.DataAnnotations;

namespace CallTrak_System.Models.DataLayer
{
    public class Type
    {
        public int TypeID { get; set; }

        [Required(ErrorMessage = "Please enter a type description.")]
        public string? Description { get; set; }
    }
}
