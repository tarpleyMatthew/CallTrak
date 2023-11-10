using Microsoft.EntityFrameworkCore;

namespace CallTrak_System.Models
{
    public class CallTrakContext: DbContext
    {
        public CallTrakContext(DbContextOptions<CallTrakContext> options) 
            :base(options)
        { }

        public DbSet<CallTrak> CallTraks { get; set; }

        #region seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallTrak>().HasData(
                new CallTrak
                {
                    CallTrakID = 1,
                    DescriptionContents = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    ActionContents = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\""
                },
                new CallTrak
                {
                    CallTrakID = 2,
                    DescriptionContents = "Calltrak 2",
                    ActionContents = "Havent done much",
                    DevNotesContents = "some dev notes",
                    BillingNotesContents = "$500000"
                },
                new CallTrak
                {
                    CallTrakID = 3,
                    DescriptionContents = "another Calltrack",
                    ActionContents = "We are just starting",
                    DevNotesContents = "hope this works",
                    BillingNotesContents = "Free"
                }

            );
        }
        #endregion
    }
}
