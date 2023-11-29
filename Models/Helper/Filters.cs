namespace CallTrak_System.Models.Helper
{
    public class Filters
    {
        public Filters(int[] filters) 
        {
            EmployeeID = filters[0];
            ClientID = filters[1];
            StatusID = filters[2];
            PriorityID = filters[3];
        }

        //properties
        public int EmployeeID { get; set; }
        public int ClientID { get; set; }
        public int StatusID { get; set; }
        public int PriorityID { get; set; }

        public bool HasEmployee => EmployeeID != 0;
        public bool HasClient => ClientID != 0;
        public bool HasStatus => StatusID != 0;
        public bool HasPriority => PriorityID != 0;

        
    }
}
