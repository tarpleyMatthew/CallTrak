using CallTrak_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

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
            CallTrakViewModel model = new CallTrakViewModel();

            model.CallTraks = context.CallTraks
                .Include(c => c.Employee)
                .Include(c => c.Type)
                .Include(c => c.Employee)
                .OrderBy(c => c.CallTrakID).ToList();
            model.Employees = context.Employees.ToList();
            model.Clients = context.Clients.ToList();
            model.Statuses = context.Statuses.ToList();
            model.Types = context.Types.ToList();


            return View(model);
        }

    }
}