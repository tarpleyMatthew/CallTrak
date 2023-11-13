using System;
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
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "CallTraks",
                columns: table => new
                {
                    CallTrakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevNotesContents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingNotesContents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    StatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallTraks", x => x.CallTrakID);
                    table.ForeignKey(
                        name: "FK_CallTraks_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CallTraks_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CallTraks_Statuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Statuses",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CallTraks_Types_TypeID",
                        column: x => x.TypeID,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HTran",
                columns: table => new
                {
                    HoursID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    CallTrakID = table.Column<int>(type: "int", nullable: false),
                    HoursWorked = table.Column<double>(type: "float", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HTran", x => x.HoursID);
                    table.ForeignKey(
                        name: "FK_HTran_CallTraks_CallTrakID",
                        column: x => x.CallTrakID,
                        principalTable: "CallTraks",
                        principalColumn: "CallTrakID",
                        onDelete: ReferentialAction.NoAction,
                        onUpdate: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HTran_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.NoAction,
                        onUpdate: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientID", "Name" },
                values: new object[,]
                {
                    { 1, "SiverCreek Software" },
                    { 2, "Amazon Produce Network" },
                    { 3, "Farm Art" },
                    { 4, "Idaho State Liquor" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "IsAdmin", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "Administrator", true, "", "admn", "admn" },
                    { 2, "Matt", false, "Tarpley", "Torrance67!", "mtarpley" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusID", "Description" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "Complete" },
                    { 3, "In Progress" },
                    { 4, "To be Assigned" },
                    { 5, "Archived" },
                    { 6, "In Review" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypeID", "Description" },
                values: new object[,]
                {
                    { 1, "SUPP CONT" },
                    { 2, "MOD" },
                    { 3, "ESTIMATE" },
                    { 4, "FIX" },
                    { 5, "GENERAL" },
                    { 6, "NEW INSTALL" }
                });

            migrationBuilder.InsertData(
                table: "CallTraks",
                columns: new[] { "CallTrakID", "ActionContents", "BillingNotesContents", "ClientID", "DescriptionContents", "DevNotesContents", "EmployeeID", "StatusID", "TypeID" },
                values: new object[,]
                {
                    { 1, "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"", null, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, 2, 3, 5 },
                    { 2, "Havent done much", "$500000", 2, "Calltrak 2", "some dev notes", 1, 1, 6 },
                    { 3, "We are just starting", "Free", 4, "another Calltrack", "hope this works", 1, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CallTraks_ClientID",
                table: "CallTraks",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_CallTraks_EmployeeID",
                table: "CallTraks",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_CallTraks_StatusID",
                table: "CallTraks",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_CallTraks_TypeID",
                table: "CallTraks",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_HTran_CallTrakID",
                table: "HTran",
                column: "CallTrakID");

            migrationBuilder.CreateIndex(
                name: "IX_HTran_EmployeeID",
                table: "HTran",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HTran");

            migrationBuilder.DropTable(
                name: "CallTraks");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
