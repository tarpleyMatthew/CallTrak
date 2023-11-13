namespace CallTrak_System.Models
{
    public class Hours
    {
        public int HoursID { get; set; }

        //FK
        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }

        //FK
        public int CallTrakID { get; set; }
        public CallTrak? CallTrak { get; set; }

        public double? HoursWorked { get; set; }
        public DateTime? Date { get; set; }
    }
}
