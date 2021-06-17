using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneSalesCRM.Migrations
{
    public partial class LocationID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Company");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
