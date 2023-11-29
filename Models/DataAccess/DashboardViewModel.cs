using CallTrak_System.Models.DataLayer;
using CallTrak_System.Models.Helper;

namespace CallTrak_System.Models.DataAccess
{
    public class DashBoardViewModel
    {
        
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
        public Filters? Filters { get; set; }
        public int[] SelectedFilters { get; set; }

        //list of CTs
        public List<CallTrak> CallTraks { get; set; } = new List<CallTrak>();

        #endregion


    }
}
