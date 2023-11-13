using System.ComponentModel.DataAnnotations;

namespace CallTrak_System.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter employee first name.")]
        public string? FirstName { get; set; }


        [Required(ErrorMessage = "Please enter employee last name.")]
        public string? LastName { get; set; }


        [Required(ErrorMessage = "Please enter employee user name.")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "Please enter a password.")]
        public string? Password { get; set; }


        [Required(ErrorMessage = "Please set employee permissions.")]
        public bool IsAdmin { get; set; }
    }
}
