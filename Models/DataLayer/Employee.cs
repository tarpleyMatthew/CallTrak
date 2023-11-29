using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CallTrak_System.Models.DataLayer
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter employee first name.")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "Employee first name cannot contain spaces, special characters, or numbers.")]
        public string? FirstName { get; set; }


        [Required(ErrorMessage = "Please enter employee last name.")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "Employee last name cannot contain spaces, special characters, or numbers.")]
        public string? LastName { get; set; }


        [Required(ErrorMessage = "Please enter employee user name.")]
        [RegularExpression("^[a-zA-Z0-9 ]+$",
            ErrorMessage = "Username may not contain special characters.")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "Please enter a password.")]
        [Compare("ConfirmPassword")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d\s]).{6,}$",
            ErrorMessage = "Password must be at least 6 characters long and include at least one lowercase letter, one uppercase letter, and one special character.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [Display(Name = "Confirm Password")]
        [NotMapped]
        public string? ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please set employee permissions.")]
        public bool IsAdmin { get; set; }

        public string Initials => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)
            && FirstName.Length > 0 && LastName.Length > 0
            ? FirstName.Substring(0, 1) + LastName.Substring(0, 1)
            : "No First or Last Name";
    }
}
