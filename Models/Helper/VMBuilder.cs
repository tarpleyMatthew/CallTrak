using CallTrak_System.Models.DataAccess;
using CallTrak_System.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CallTrak_System.Models.Helper
{
    public class VMBuilder
    {

        //Set ViewModel with Existing CT
        public static CallTrakViewModel SetVmWithExistingCt(CallTrakContext context, CallTrak callTrak, int id)
        {
            var model = new CallTrakViewModel
            {
                CurrentCT = callTrak,
                Clients = context.Clients.OrderBy(c => c.Name).ToList(),
                Employees = context.Employees.OrderBy(c => c.FirstName).ToList(),
                Statuses = context.Statuses.OrderBy(c => c.Description).ToList(),
                Types = context.Types.OrderBy(c => c.Description).ToList(),
                Modules = context.Modules.OrderBy(m => m.Description).ToList(),
                Priorities = context.Priorities.OrderBy(p => p.Description).ToList(),
                Versions = context.Versions.OrderBy(v => v.Description).ToList(),

                WorkLogs = context.WorkLogs.Where(w => w.CallTrakID == id) //Worklogs for selected CT
                    .Include(e => e.Employee)
                    .ToList(),

            };

            model.CurrentCT.HoursIn = model.WorkLogs.Sum(w => w.HoursWorked); //calc hours in

            return model;
        }


        //Set ViewModel for new CT
        public static CallTrakViewModel SetVmForNewCT(CallTrakContext context)
        {
            var viewModel = new CallTrakViewModel
            {
                Clients = context.Clients.OrderBy(c => c.Name).ToList(),
                Employees = context.Employees.OrderBy(c => c.FirstName).ToList(),
                Statuses = context.Statuses.OrderBy(c => c.Description).ToList(),
                Types = context.Types.OrderBy(c => c.Description).ToList(),
                Modules = context.Modules.OrderBy(m => m.Description).ToList(),
                Priorities = context.Priorities.OrderBy(p => p.Description).ToList(),
                Versions = context.Versions.OrderBy(v => v.Description).ToList()
            };

            return viewModel;
        }
    }
}
