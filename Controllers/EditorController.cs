using CallTrak_System.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using Microsoft.Identity.Client;
using System.Security.Cryptography.Xml;
using CallTrak_System.Models.DataAccess;

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

        //get CallTrak

        [HttpGet]
        public IActionResult Index(int id = 1)
        {
            //validate entry if load from search
            int maxCallTrak = context.CallTraks.Max(c => c.CallTrakID);
            if(id < 1 || id > maxCallTrak)
            {
                TempData["AlertMessage"] = "Invalid ID. Please enter a valid ID.";
                return RedirectToAction("Index"); //reloads index w/ default ID of 1. Change later
            }

            //find ct
            var callTrak = context.CallTraks.Find(id);

            //if ct null return error
            if (callTrak == null)
            {
                TempData["AlertMessage"] = "CallTrak not found.";
                return RedirectToAction("Index"); //reloads index w/ default ID of 1. Change later
            }

            //Set ViewModel using Helper class
            var viewModel = VMBuilder.SetVmWithExistingCt(context, callTrak, id);
            return View(viewModel);
        }

        //Post action handles saving CT, and edit/updating Worklogs, this way everything can take place in one form.

        [HttpPost]
        public IActionResult Index(CallTrakViewModel vm, string submitButton, int deleteID = 0)
        {
            if (ModelState.IsValid)
            {
                if (vm.CurrentCT.CallTrakID == 0) //if a new CT
                {
                    vm.CurrentCT.DateOpened = DateTime.Now;
                    TempData["AlertMessage"] = "CT Added.";

                    context.Add(vm.CurrentCT);
                }
                else
                {
                    switch(submitButton) //switch to exam which button activated the post and behave accordingly
                    {
                        case "save":
                            TempData["AlertMessage"] = "CT Updated";
                            context.Update(vm.CurrentCT);
                            break;

                        case "add-hrs":
                            TempData["AlertMessage"] = "Hours Added";
                            vm.CurrentWL.DateWorked = DateTime.Now;

                            context.Update(vm.CurrentWL);
                            context.Update(vm.CurrentCT);
                            break;

                        case "del-hrs":
                            if(deleteID != 0)
                            {
                                TempData["AlertMessage"] = "Hours Deleted";
                                vm.CurrentWL = context.WorkLogs.Find(deleteID);

                                context.Remove(vm.CurrentWL);
                                context.Update(vm.CurrentCT);
                            }
                            break;
                    }
                }

                context.SaveChanges(); //save changes in DB

                if (submitButton == "save")
                {
                    return RedirectToAction("Index", "Home"); //redirect to dash
                }
                else
                {
                    return RedirectToAction("Index", new {id = vm.CurrentCT.CallTrakID}); //reload CT editor with current/updated CT
                }  
            } 
            else
            {
                TempData["AlertMessage"] = "Model state not valid";
                return View(vm); // <- change required. Not a good way to handle. Come back to later
            }
        }

        //Add action using helper to build ViewModel for new CT
        [HttpGet]
        public IActionResult Add()
        {
            var viewModel = VMBuilder.SetVmForNewCT(context);
            return View("Index", viewModel);

        }

    }
}