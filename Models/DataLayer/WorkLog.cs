using System.ComponentModel.DataAnnotations;


namespace CallTrak_System.Models.DataLayer
{
    public class WorkLog
    {
        public int WorkLogID { get; set; }


        public DateTime DateWorked { get; set; }

        public double HoursWorked { get; set; }


        //FK Properties
        public int? CallTrakID { get; set; }
        public CallTrak? CallTrak { get; set; }

        public int? EmployeeID { get; set; }
        public Employee? Employee { get; set; }

        public int? ClientID { get; set; }
        public Client? Client { get; set; }

    }
}
