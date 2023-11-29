using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using CallTrak_System.Models.DataAccess;
using CallTrak_System.Models.Helper;
using CallTrak_System.Models.DataLayer;

namespace CallTrak_System.Controllers
{
    public class HomeController : Controller
    {
 
        //set up context obj
        private CallTrakContext context { get; set; }
        public HomeController(CallTrakContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            DashBoardViewModel model = new DashBoardViewModel();

            //adds list of ct's and include related data to viewmodel
            model.CallTraks = context.CallTraks
                .Include(c => c.Employee)
                .Include(c => c.Type)
                .Include(c => c.Status)
                .OrderBy(c => c.CallTrakID).ToList();

            //adds other lists to view model
            model.Employees = context.Employees.ToList();
            model.Clients = context.Clients.ToList();
            model.Statuses = context.Statuses.ToList();
            model.Types = context.Types.ToList();


            return View(model);
        }
        

        [HttpPost]
        public IActionResult Index(int[] filterArray)
        {
            DashBoardViewModel model = new DashBoardViewModel();

            var filters = new Filters(filterArray);

            model.SelectedFilters = filterArray;
            model.Employees = context.Employees.ToList();
            model.Clients = context.Clients.ToList();
            model.Statuses = context.Statuses.ToList();
            model.Types = context.Types.ToList();
            model.Priorities = context.Priorities.ToList();

            //generate query based on filter
            IQueryable<CallTrak> query = context.CallTraks
                .Include(c => c.Employee)
                .Include(c => c.Type)
                .Include(c => c.Status)
                .Include(c => c.Client)
                .Include(c => c.Priority);

            if(filters.HasEmployee)
            {
                query = query.Where(c => c.EmployeeID == filters.EmployeeID);
            }
            if(filters.HasClient)
            {
                query = query.Where(c => c.ClientID == filters.ClientID);
            }
            if(filters.HasStatus)
            {
                query = query.Where(c => c.StatusID == filters.StatusID);
            }
            if(filters.HasPriority)
            {
                query = query.Where(c => c.PriorityID== filters.PriorityID);
            }

            var callTraks = query.OrderBy(c => c.CallTrakID).ToList();
            model.CallTraks = callTraks;

            return View(model);


        }
        

    }
}