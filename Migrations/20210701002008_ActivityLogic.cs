using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneSalesCRM.Migrations
{
    public partial class ActivityLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Activity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Activity");
        }
    }
}
