using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CallTrak_System.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CallTraks",
                columns: table => new
                {
                    CallTrakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevNotesContents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingNotesContents = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallTraks", x => x.CallTrakID);
                });

            migrationBuilder.InsertData(
                table: "CallTraks",
                columns: new[] { "CallTrakID", "ActionContents", "BillingNotesContents", "DescriptionContents", "DevNotesContents" },
                values: new object[,]
                {
                    { 1, "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"", null, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null },
                    { 2, "Havent done much", "$500000", "Calltrak 2", "some dev notes" },
                    { 3, "We are just starting", "Free", "another Calltrack", "hope this works" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CallTraks");
        }
    }
}
