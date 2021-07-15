﻿// <auto-generated />
using System;
using CapstoneSalesCRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CapstoneSalesCRM.Migrations
{
    [DbContext(typeof(CapstoneSalesCRMContext))]
    [Migration("20210715012046_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CapstoneSalesCRM.Models.Activity", b =>
                {
                    b.Property<int>("ActivityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityTaskID")
                        .HasColumnType("int");

                    b.Property<int>("ContactID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCompleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateScheduled")
                        .HasColumnType("datetime2");

                    b.Property<string>("HowToNotify")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("WhoToNotify")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityID");

                    b.HasIndex("ActivityTaskID");

                    b.HasIndex("ContactID");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.ActivityTask", b =>
                {
                    b.Property<int>("ActivityTaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaskDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityTaskID");

                    b.ToTable("ActivityTask");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IndustryID")
                        .HasColumnType("int");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.HasIndex("IndustryID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CellPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("ContactMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactTypeID")
                        .HasColumnType("int");

                    b.Property<string>("ContactTypeID1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastDateContacted")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("Prefix")
                        .HasColumnType("int");

                    b.Property<int>("Pronouns")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("SourceID")
                        .HasColumnType("int");

                    b.Property<string>("StateID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("ContactTypeID1");

                    b.HasIndex("LocationID");

                    b.HasIndex("RoleID");

                    b.HasIndex("SourceID");

                    b.HasIndex("StateID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.ContactType", b =>
                {
                    b.Property<string>("ContactTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ContactTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactTypeID");

                    b.ToTable("ContactType");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Industry", b =>
                {
                    b.Property<int>("IndustryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IndustryID");

                    b.ToTable("Industry");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LocationID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("StateID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Source", b =>
                {
                    b.Property<int>("SourceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SourceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SourceID");

                    b.ToTable("Source");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.State", b =>
                {
                    b.Property<string>("StateID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.ToTable("State");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Activity", b =>
                {
                    b.HasOne("CapstoneSalesCRM.Models.ActivityTask", "ActivityTask")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityTaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapstoneSalesCRM.Models.Contact", "Contact")
                        .WithMany("Activities")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Company", b =>
                {
                    b.HasOne("CapstoneSalesCRM.Models.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Contact", b =>
                {
                    b.HasOne("CapstoneSalesCRM.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.HasOne("CapstoneSalesCRM.Models.ContactType", null)
                        .WithMany("Contacts")
                        .HasForeignKey("ContactTypeID1");

                    b.HasOne("CapstoneSalesCRM.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapstoneSalesCRM.Models.Role", "Role")
                        .WithMany("Contacts")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapstoneSalesCRM.Models.Source", "Source")
                        .WithMany("Contacts")
                        .HasForeignKey("SourceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapstoneSalesCRM.Models.State", "State")
                        .WithMany("Contacts")
                        .HasForeignKey("StateID");
                });

            modelBuilder.Entity("CapstoneSalesCRM.Models.Location", b =>
                {
                    b.HasOne("CapstoneSalesCRM.Models.Company", "Company")
                        .WithMany("Locations")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapstoneSalesCRM.Models.State", "State")
                        .WithMany("Locations")
                        .HasForeignKey("StateID");
                });
#pragma warning restore 612, 618
        }
    }
}
