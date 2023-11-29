using CallTrak_System.Models.DataLayer;

namespace CallTrak_System.Models.DataAccess
{
    public class CallTrakViewModel
    {
        //constructor 
        public CallTrakViewModel()
        {
            CurrentCT = new CallTrak();
            CurrentWL = new WorkLog();
        }
        //Default values because it was creating a modelstate invalid issue
        #region Attributes

        //CT attributes
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Status> Statuses { get; set; } = new List<Status>();
        public List<DataLayer.Type> Types { get; set; } = new List<DataLayer.Type>();
        public List<Module> Modules { get; set; } = new List<Module>();
        public List<Priority> Priorities { get; set; } = new List<Priority>();
        public List<DataLayer.Version> Versions { get; set; } = new List<DataLayer.Version>();

        //list of CTs/Current CT
        public List<CallTrak> CallTraks { get; set; } = new List<CallTrak>();
        public CallTrak CurrentCT { get; set; }

        //List of Worklogs/Current WL
        public List<WorkLog> WorkLogs { get; set; } = new List<WorkLog>();

        public WorkLog CurrentWL { get; set; }
        #endregion


    }
}
