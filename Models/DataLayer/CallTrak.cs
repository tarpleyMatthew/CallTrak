using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CallTrak_System.Models.DataLayer
{
    public class CallTrak
    {
        #region Properties
        public int CallTrakID { get; set; }

        //header attributes
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOpened { get; set; }

        [Required(ErrorMessage = "Short description required.")]
        public string? ShortDesc { get; set; }

        public string? Company { get; set; }

        public string? MenuPath { get; set; }


        //text area attributes

        [Required(ErrorMessage = "Description required.")]
        public string? DescriptionContents { get; set; }

        public string? ActionContents { get; set; }

        public string? DevNotesContents { get; set; }
        public string? BillingNotesContents { get; set; }


        //status checkboxes
        public bool IsApproved { get; set; } = false;
        public bool IsBeginCode { get; set; } = false;
        public bool IsEndCode { get; set; } = false;
        public bool IsCodeRev { get; set; } = false;
        public bool IsBeginTest { get; set; } = false;
        public bool IsEndTest { get; set; } = false;
        public bool IsReadyInstall { get; set; } = false;
        public bool IsInTest { get; set; } = false;
        public bool IsInLive { get; set; } = false;
        public bool IsConfirmed { get; set; } = false;
        public bool IsBilled { get; set; } = false;

        //status dates
        public DateTime? ApprovedDate { get; set; }
        public DateTime? BeginCodeDate { get; set; }
        public DateTime? EndCodeDate { get; set; }
        public DateTime? CodeRevDate { get; set; }
        public DateTime? BeginTestDate { get; set; }
        public DateTime? EndTestDate { get; set; }
        public DateTime? ReadyInstallDate { get; set; }
        public DateTime? InTestDate { get; set; }
        public DateTime? InLiveDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public DateTime? BilledDate { get; set; }


        //hours attributes
        public double DevEstHrs { get; set; }
        public double QuoteEstHrs { get; set; }
        public double HoursIn { get; set; }
        public double Rate { get; set; }
        public double HoursBilled { get; set; }



        //FK properties
        public int? EmployeeID { get; set; }
        public Employee? Employee { get; set; }


        public int? ClientID { get; set; }
        public Client? Client { get; set; }


        public int? TypeID { get; set; }
        public Type? Type { get; set; }


        [Required(ErrorMessage = "Status required.")]
        public int StatusID { get; set; }
        public Status? Status { get; set; }

        public int? PriorityID { get; set; }
        public Priority? Priority { get; set; }

        public int? ModuleID { get; set; }
        public Module? Module { get; set; }

        public int? VersionID { get; set; }
        public Version? Version { get; set; }
        public ICollection<WorkLog>? WorkLogs { get; set; }

        #endregion
    }
}
