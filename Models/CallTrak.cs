using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CallTrak_System.Models
{
    public class CallTrak
    {
        #region Properties
        public int CallTrakID { get; set; }
        
        //text attributes

        [Required(ErrorMessage = "Please enter a description.")]
        public string? DescriptionContents { get; set; }

        [Required(ErrorMessage = "Please enter an action.")]
        public string? ActionContents { get; set; }

        public string? DevNotesContents { get; set; }
        public string? BillingNotesContents { get; set; }


        //FK
        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }

        //FK
        public int ClientID { get; set; } 
        public Client? Client { get; set; }

        //FK
        public int TypeID { get; set; }
        public Type? Type { get; set; }

        //Fk
        public int StatusID { get; set; }
        public Status? Status { get; set; }
        #endregion
    }
}
