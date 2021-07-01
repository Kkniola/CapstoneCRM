using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneSalesCRM.Migrations
{
    public partial class FirstDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityTask",
                columns: table => new
                {
                    ActivityTaskID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTask", x => x.ActivityTaskID);
                });

            migrationBuilder.CreateTable(
                name: "ContactType",
                columns: table => new
                {
                    ContactTypeID = table.Column<string>(nullable: false),
                    ContactTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactType", x => x.ContactTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    IndustryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.IndustryID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    SourceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.SourceID);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateID = table.Column<string>(nullable: false),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateID);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    IndustryID = table.Column<int>(nullable: false),
                    Website = table.Column<string>(nullable: true),
                    LinkedIn = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Company_Industry_IndustryID",
                        column: x => x.IndustryID,
                        principalTable: "Industry",
                        principalColumn: "IndustryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    CompanyID = table.Column<int>(nullable: false),
                    LocationAddress1 = table.Column<string>(nullable: true),
                    LocationAddress2 = table.Column<string>(nullable: true),
                    LocationCity = table.Column<string>(nullable: true),
                    StateID = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    MainPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Location_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_State_StateID",
                        column: x => x.StateID,
                        principalTable: "State",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    Prefix = table.Column<string>(nullable: true),
                    Pronouns = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    RoleID = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HomeAddress1 = table.Column<string>(nullable: true),
                    HomeAddress2 = table.Column<string>(nullable: true),
                    HomeCity = table.Column<string>(nullable: true),
                    StateID = table.Column<string>(nullable: true),
                    HomeZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    WorkPhone = table.Column<string>(nullable: true),
                    LinkedIn = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    ContactMethod = table.Column<string>(nullable: true),
                    EmergencyContactName = table.Column<string>(nullable: true),
                    EmergencyContactNumber = table.Column<string>(nullable: true),
                    LocationID = table.Column<int>(nullable: false),
                    SourceID = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LastDateContacted = table.Column<DateTime>(nullable: false),
                    ContactTypeID = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    SourceID1 = table.Column<int>(nullable: true),
                    ContactTypeID1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contact_ContactType_ContactTypeID1",
                        column: x => x.ContactTypeID1,
                        principalTable: "ContactType",
                        principalColumn: "ContactTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_Location_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Location",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contact_Source_SourceID1",
                        column: x => x.SourceID1,
                        principalTable: "Source",
                        principalColumn: "SourceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contact_State_StateID",
                        column: x => x.StateID,
                        principalTable: "State",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ActivityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityTaskID = table.Column<int>(nullable: false),
                    ContactID = table.Column<int>(nullable: false),
                    DateScheduled = table.Column<DateTime>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    WhoToNotify = table.Column<string>(nullable: true),
                    HowToNotify = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    DateCompleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityID);
                    table.ForeignKey(
                        name: "FK_Activity_ActivityTask_ActivityTaskID",
                        column: x => x.ActivityTaskID,
                        principalTable: "ActivityTask",
                        principalColumn: "ActivityTaskID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Activity_Contact_ContactID",
                        column: x => x.ContactID,
                        principalTable: "Contact",
                        principalColumn: "ContactID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ActivityTaskID",
                table: "Activity",
                column: "ActivityTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ContactID",
                table: "Activity",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_IndustryID",
                table: "Company",
                column: "IndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ContactTypeID1",
                table: "Contact",
                column: "ContactTypeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_LocationID",
                table: "Contact",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_RoleID",
                table: "Contact",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_SourceID1",
                table: "Contact",
                column: "SourceID1");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_StateID",
                table: "Contact",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CompanyID",
                table: "Location",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Location_StateID",
                table: "Location",
                column: "StateID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "ActivityTask");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "ContactType");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Industry");
        }
    }
}
