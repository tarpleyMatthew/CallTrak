using System.ComponentModel.DataAnnotations;

namespace CallTrak_System.Models.DataLayer
{
    public class Status
    {
        public int StatusID { get; set; }

        [Required(ErrorMessage = "Please enter status description")]
        public string? Description { get; set; }
    }
}
