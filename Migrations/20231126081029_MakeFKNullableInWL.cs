using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CallTrak_System.Migrations
{
    /// <inheritdoc />
    public partial class MakeFKNullableInWL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkLogs_CallTraks_CallTrakID",
                table: "WorkLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLogs_Clients_ClientID",
                table: "WorkLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLogs_Employees_EmployeeID",
                table: "WorkLogs");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "WorkLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "WorkLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CallTrakID",
                table: "WorkLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLogs_CallTraks_CallTrakID",
                table: "WorkLogs",
                column: "CallTrakID",
                principalTable: "CallTraks",
                principalColumn: "CallTrakID");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLogs_Clients_ClientID",
                table: "WorkLogs",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLogs_Employees_EmployeeID",
                table: "WorkLogs",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkLogs_CallTraks_CallTrakID",
                table: "WorkLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLogs_Clients_ClientID",
                table: "WorkLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkLogs_Employees_EmployeeID",
                table: "WorkLogs");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "WorkLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "WorkLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CallTrakID",
                table: "WorkLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLogs_CallTraks_CallTrakID",
                table: "WorkLogs",
                column: "CallTrakID",
                principalTable: "CallTraks",
                principalColumn: "CallTrakID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLogs_Clients_ClientID",
                table: "WorkLogs",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkLogs_Employees_EmployeeID",
                table: "WorkLogs",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
