using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneSalesCRM.Migrations
{
    public partial class CompanyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Pronouns",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Prefix",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Contact",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Pronouns",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Prefix",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
