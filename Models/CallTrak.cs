using System.ComponentModel.DataAnnotations;

namespace CallTrak_System.Models
{
    public class CallTrak
    {
        #region Properties
        public int CallTrakID { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string? DescriptionContents { get; set; }

        [Required(ErrorMessage = "Please enter an action.")]
        public string? ActionContents { get; set; }

        public string? DevNotesContents { get; set; }
        public string? BillingNotesContents { get; set; }
        #endregion
    }
}
