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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    PriorityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.PriorityId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    VersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.VersionId);
                });

            migrationBuilder.CreateTable(
                name: "CallTraks",
                columns: table => new
                {
                    CallTrakID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOpened = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShortDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionContents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevNotesContents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingNotesContents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsBeginCode = table.Column<bool>(type: "bit", nullable: false),
                    IsEndCode = table.Column<bool>(type: "bit", nullable: false),
                    IsCodeRev = table.Column<bool>(type: "bit", nullable: false),
                    IsBeginTest = table.Column<bool>(type: "bit", nullable: false),
                    IsEndTest = table.Column<bool>(type: "bit", nullable: false),
                    IsReadyInstall = table.Column<bool>(type: "bit", nullable: false),
                    IsInTest = table.Column<bool>(type: "bit", nullable: false),
                    IsInLive = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsBilled = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BeginCodeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndCodeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CodeRevDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BeginTestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReadyInstallDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InTestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InLiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BilledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DevEstHrs = table.Column<double>(type: "float", nullable: false),
                    QuoteEstHrs = table.Column<double>(type: "float", nullable: false),
                    HoursIn = table.Column<double>(type: "float", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    HoursBilled = table.Column<double>(type: "float", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: true),
                    ClientID = table.Column<int>(type: "int", nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    PriorityID = table.Column<int>(type: "int", nullable: true),
                    ModuleID = table.Column<int>(type: "int", nullable: true),
                    VersionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallTraks", x => x.CallTrakID);
                    table.ForeignKey(
                        name: "FK_CallTraks_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID");
                    table.ForeignKey(
                        name: "FK_CallTraks_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_CallTraks_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleId");
                    table.ForeignKey(
                        name: "FK_CallTraks_Priorities_PriorityID",
                        column: x => x.PriorityID,
                        principalTable: "Priorities",
                        principalColumn: "PriorityId");
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
                        principalColumn: "TypeID");
                    table.ForeignKey(
                        name: "FK_CallTraks_Versions_VersionID",
                        column: x => x.VersionID,
                        principalTable: "Versions",
                        principalColumn: "VersionId");
                });

            migrationBuilder.CreateTable(
                name: "WorkLogs",
                columns: table => new
                {
                    WorkLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateWorked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursWorked = table.Column<double>(type: "float", nullable: false),
                    CallTrakID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLogs", x => x.WorkLogID);
                    table.ForeignKey(
                        name: "FK_WorkLogs_CallTraks_CallTrakID",
                        column: x => x.CallTrakID,
                        principalTable: "CallTraks",
                        principalColumn: "CallTrakID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WorkLogs_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_WorkLogs_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientID", "Alias", "Name" },
                values: new object[,]
                {
                    { 1, "SCS", "SiverCreek Software" },
                    { 2, "APN", "Amazon Produce Network" },
                    { 3, "FAA", "Farm Art" },
                    { 4, "ISLD", "Idaho State Liquor" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "FirstName", "IsAdmin", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "Administrator", true, "Administrator", "Admn1!", "admn" },
                    { 2, "Matt", false, "Tarpley", "Torrance67!", "mtarpley" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "Description" },
                values: new object[,]
                {
                    { 1, "1 - HIGH" },
                    { 2, "3 - MED" },
                    { 3, "5 - LOW" },
                    { 4, "0 - CRIT" }
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
                    { 5, "MERGE" },
                    { 6, "NEW INSTALL" },
                    { 7, "AFTER HOUR" },
                    { 8, "DATA" },
                    { 9, "SUPP BILL" },
                    { 10, "TRAINING" },
                    { 11, "UPGRADE" },
                    { 12, "VP BASE" }
                });

            migrationBuilder.InsertData(
                table: "CallTraks",
                columns: new[] { "CallTrakID", "ActionContents", "ApprovedDate", "BeginCodeDate", "BeginTestDate", "BilledDate", "BillingNotesContents", "ClientID", "CodeRevDate", "Company", "ConfirmedDate", "DateOpened", "DescriptionContents", "DevEstHrs", "DevNotesContents", "EmployeeID", "EndCodeDate", "EndTestDate", "HoursBilled", "HoursIn", "InLiveDate", "InTestDate", "IsApproved", "IsBeginCode", "IsBeginTest", "IsBilled", "IsCodeRev", "IsConfirmed", "IsEndCode", "IsEndTest", "IsInLive", "IsInTest", "IsReadyInstall", "MenuPath", "ModuleID", "PriorityID", "QuoteEstHrs", "Rate", "ReadyInstallDate", "ShortDesc", "StatusID", "TypeID", "VersionID" },
                values: new object[,]
                {
                    { 1, "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"", null, null, null, null, null, 1, null, null, null, null, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 0.0, null, 2, null, null, 0.0, 0.0, null, null, false, false, false, false, false, false, false, false, false, false, false, null, null, null, 0.0, 0.0, null, "Continuing on this project", 3, 5, null },
                    { 2, "Havent done much", null, null, null, null, "$500000", 2, null, null, null, null, "Calltrak 2", 0.0, "some dev notes", 1, null, null, 0.0, 0.0, null, null, false, false, false, false, false, false, false, false, false, false, false, null, null, null, 0.0, 0.0, null, "BOL to include net and gross weight", 1, 6, null },
                    { 3, "We are just starting", null, null, null, null, "Free", 4, null, null, null, null, "another Calltrack", 0.0, "hope this works", 1, null, null, 0.0, 0.0, null, null, false, false, false, false, false, false, false, false, false, false, false, null, null, null, 0.0, 0.0, null, "potran not being updated properly", 2, 2, null }
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
                name: "IX_CallTraks_ModuleID",
                table: "CallTraks",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_CallTraks_PriorityID",
                table: "CallTraks",
                column: "PriorityID");

            migrationBuilder.CreateIndex(
                name: "IX_CallTraks_StatusID",
                table: "CallTraks",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_CallTraks_TypeID",
                table: "CallTraks",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CallTraks_VersionID",
                table: "CallTraks",
                column: "VersionID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLogs_CallTrakID",
                table: "WorkLogs",
                column: "CallTrakID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLogs_ClientID",
                table: "WorkLogs",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkLogs_EmployeeID",
                table: "WorkLogs",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkLogs");

            migrationBuilder.DropTable(
                name: "CallTraks");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Versions");
        }
    }
}
