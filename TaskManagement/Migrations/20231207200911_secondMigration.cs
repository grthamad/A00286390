using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManagementApi.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tasks_StaffId",
                table: "Tasks",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Staffs_StaffId",
                table: "Tasks",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Staffs_StaffId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_StaffId",
                table: "Tasks");
        }
    }
}
