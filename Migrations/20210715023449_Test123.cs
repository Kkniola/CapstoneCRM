using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneSalesCRM.Migrations
{
    public partial class Test123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Company_CompanyID",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_CompanyID",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Contact",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CompanyID",
                table: "Contact",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Company_CompanyID",
                table: "Contact",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
