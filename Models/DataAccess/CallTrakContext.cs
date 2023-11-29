using CallTrak_System.Models.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace CallTrak_System.Models.DataAccess
{
    public class CallTrakContext : DbContext
    {
        public CallTrakContext(DbContextOptions<CallTrakContext> options)
            : base(options)
        { }

        //tables
        public DbSet<CallTrak> CallTraks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DataLayer.Type> Types { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<DataLayer.Version> Versions { get; set; }
        public DbSet<WorkLog> WorkLogs { get; set; }


        #region seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //The rest of client, versions, and modules will have data inserted in SSMS
            //Client
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    ClientID = 1,
                    Name = "SiverCreek Software",
                    Alias = "SCS"
                },
                new Client
                {
                    ClientID = 2,
                    Name = "Amazon Produce Network",
                    Alias = "APN"
                },
                new Client
                {
                    ClientID = 3,
                    Name = "Farm Art",
                    Alias = "FAA"
                },
                new Client
                {
                    ClientID = 4,
                    Name = "Idaho State Liquor",
                    Alias = "ISLD"
                }
            );
            //Types
            modelBuilder.Entity<DataLayer.Type>().HasData(
                new DataLayer.Type
                {
                    TypeID = 1,
                    Description = "SUPP CONT"
                },
                new DataLayer.Type
                {
                    TypeID = 2,
                    Description = "MOD"
                },
                new DataLayer.Type
                {   
                    TypeID = 3,
                    Description = "ESTIMATE"
                },
                new DataLayer.Type
                {
                    TypeID = 4,
                    Description = "FIX"
                },
                new DataLayer.Type
                {
                    TypeID = 5,
                    Description = "MERGE"
                },
                new DataLayer.Type
                {
                    TypeID = 6,
                    Description = "NEW INSTALL"
                },
                new DataLayer.Type
                {
                    TypeID = 7,
                    Description = "AFTER HOUR"
                },
                new DataLayer.Type
                {
                    TypeID = 8,
                    Description = "DATA"
                },
                new DataLayer.Type
                {
                    TypeID = 9,
                    Description = "SUPP BILL"
                },
                new DataLayer.Type
                {
                    TypeID = 10,
                    Description = "TRAINING"
                },
                new DataLayer.Type
                {
                    TypeID = 11,
                    Description = "UPGRADE"
                },
                new DataLayer.Type
                {
                    TypeID = 12,
                    Description = "VP BASE"
                }
            );
            //Statuses
            modelBuilder.Entity<Status>().HasData(
                new Status
                {
                    StatusID = 1,
                    Description = "Open"
                },
                new Status
                {
                    StatusID = 2,
                    Description = "Complete"
                },
                new Status
                {
                    StatusID = 3,
                    Description = "In Progress"
                },
                new Status
                {
                    StatusID = 4,
                    Description = "To be Assigned"
                },
                new Status
                {
                    StatusID = 5,
                    Description = "Archived"
                },
                new Status
                {
                    StatusID = 6,
                    Description = "In Review"
                }

            );
            //Priorities
            modelBuilder.Entity<Priority>().HasData(
                new Priority
                {
                    PriorityId = 1,
                    Description = "1 - HIGH"
                },
                 new Priority
                 {
                     PriorityId = 2,
                     Description = "3 - MED"
                 },
                 new Priority
                 {
                     PriorityId = 3,
                     Description = "5 - LOW"
                 },
                 new Priority
                 {
                     PriorityId = 4,
                     Description = "0 - CRIT"
                 }
            );

            //Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Administrator",
                    LastName = "Administrator",
                    UserName = "admn",
                    Password = "Admn1!",
                    IsAdmin = true
                },
                new Employee
                {
                    EmployeeID = 2,
                    FirstName = "Matt",
                    LastName = "Tarpley",
                    UserName = "mtarpley",
                    Password = "Torrance67!",
                    IsAdmin = false
                }
            );
            //CT'S
            modelBuilder.Entity<CallTrak>().HasData(
                new CallTrak
                {
                    CallTrakID = 1,
                    ShortDesc = "Continuing on this project",
                    DescriptionContents = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ActionContents = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"",
                    EmployeeID = 2,
                    ClientID = 1,
                    TypeID = 5,
                    StatusID = 3,
                },
                new CallTrak
                {
                    CallTrakID = 2,
                    ShortDesc = "BOL to include net and gross weight",
                    DescriptionContents = "Calltrak 2",
                    ActionContents = "Havent done much",
                    DevNotesContents = "some dev notes",
                    BillingNotesContents = "$500000",
                    EmployeeID = 1,
                    ClientID = 2,
                    TypeID = 6,
                    StatusID = 1,
                },
                new CallTrak
                {
                    CallTrakID = 3,
                    ShortDesc = "potran not being updated properly",
                    DescriptionContents = "another Calltrack",
                    ActionContents = "We are just starting",
                    DevNotesContents = "hope this works",
                    BillingNotesContents = "Free",
                    EmployeeID = 1,
                    ClientID = 4,
                    TypeID = 2,
                    StatusID = 2,
                }

            );
        }
        #endregion
    }
}
