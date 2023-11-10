using CallTrak_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;

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

            return View(callTrak);
        }

        //post Index action from save button that will add or update depending if CT passed is empty

        [HttpPost]
        public IActionResult Index(CallTrak callTrak)
        {
            if (ModelState.IsValid)
            {
                if (callTrak.CallTrakID == 0)
                {
                    context.Add(callTrak);
                }
                else
                {
                    context.Update(callTrak);
                }
    
                context.SaveChanges();
                return RedirectToAction("Index");

            } 
            else
            {
                return View(callTrak);
            }

        }

        //get add action that passes empty CT
        [HttpGet]
        public IActionResult Add()
        {
            return View("Index", new CallTrak());

        }

    }
}