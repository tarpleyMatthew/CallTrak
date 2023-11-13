using CallTrak_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;

namespace CallTrak_System.Controllers
{
    public class EditorController : Controller
    {
 
        //set up context obj
        private CallTrakContext context { get; set; }
        public EditorController(CallTrakContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index(int id = 1)
        {
            //validate entry if load from search
            int totalCallTraks = context.CallTraks.Count();
            if(id < 1 || id > totalCallTraks)
            {
                TempData["AlertMessage"] = "Invalid ID. Please enter a valid ID.";
                return RedirectToAction("Index");
            }

            //find ct
            var callTrak = context.CallTraks.Find(id);

            //if ct null return error
            if (callTrak == null)
            {
                TempData["AlertMessage"] = "CallTrak not found.";
                return RedirectToAction("Index");
            }

            var model = new CallTrakViewModel
            {
                CurrentCT = callTrak,
                Clients = context.Clients.OrderBy(c => c.Name).ToList(),
                Employees= context.Employees.OrderBy(c => c.FirstName).ToList(),
                Statuses= context.Statuses.OrderBy(c => c.Description).ToList(),
                Types= context.Types.OrderBy(c => c.Description).ToList(),

            };

            return View(model);
        }

        //post Index action from save button that will add or update depending if CT passed is empty

        [HttpPost]
        public IActionResult Index(CallTrakViewModel callTrak)
        {

            if (ModelState.IsValid)
            {
                if (callTrak.CurrentCT.CallTrakID == 0)
                {
                    TempData["AlertMessage"] = "New CT added.";
                    context.Add(callTrak.CurrentCT);
                }
                else
                {
                    TempData["AlertMessage"] = "CT updated.";
                    context.Update(callTrak.CurrentCT);
                }
    
                context.SaveChanges();
                return RedirectToAction("Index");

            } 
            else
            {
                TempData["AlertMessage"] = "Model state not valid";
                return View(callTrak);
            }

        }

        //get add action that passes empty CT
        [HttpGet]
        public IActionResult Add()
        {

            var model = new CallTrakViewModel
            {
                CurrentCT = new CallTrak(),
                Clients = context.Clients.OrderBy(c => c.Name).ToList(),
                Employees = context.Employees.OrderBy(c => c.FirstName).ToList(),
                Statuses = context.Statuses.OrderBy(c => c.Description).ToList(),
                Types = context.Types.OrderBy(c => c.Description).ToList(),

            };

            return View("Index", model);

        }

    }
}