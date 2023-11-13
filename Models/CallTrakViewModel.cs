namespace CallTrak_System.Models
{
    public class CallTrakViewModel
    {
        //constructor 
        public CallTrakViewModel()
        {
            CurrentCT = new CallTrak();
        }
        //Default values because it was creating a modelstate invalid issue
        #region Attributes
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Status> Statuses { get; set; } = new List<Status>();
        public List<Type> Types { get; set; } = new List<Type>();

        public List<CallTrak> CallTraks { get; set; } = new List<CallTrak>();
        public CallTrak CurrentCT { get; set; }
        #endregion
        
        /*
        #region Properties
        public Client SelectedClient
        {
            get
            {
                return Clients.FirstOrDefault(c => c.ClientID == CurrentCT.ClientID);
            }
        }
        public Employee AssignedEmployee
        {
            get
            {
                return Employees.FirstOrDefault(c => c.EmployeeID == CurrentCT.EmployeeID);
            }
        }

        public Status CurrentStatus
        {
            get 
            { 
                return Statuses.FirstOrDefault(c => c.StatusID == CurrentCT.StatusID);
            }
        }

        public Type SelectedType
        {
            get
            {
                return Types.FirstOrDefault(c => c.TypeID == CurrentCT.TypeID);
            }
        }

        #endregion
        */
        
    }
}
