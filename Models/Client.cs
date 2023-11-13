using System.ComponentModel.DataAnnotations;

namespace CallTrak_System.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [Required(ErrorMessage = "Please enter a client name.")]
        public string? Name { get; set; }
    }
}
