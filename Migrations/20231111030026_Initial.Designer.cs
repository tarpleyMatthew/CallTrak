﻿// <auto-generated />
using System;
using CallTrak_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CallTrak_System.Migrations
{
    [DbContext(typeof(CallTrakContext))]
    [Migration("20231111030026_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CallTrak_System.Models.CallTrak", b =>
                {
                    b.Property<int>("CallTrakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CallTrakID"));

                    b.Property<string>("ActionContents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingNotesContents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionContents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevNotesContents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasKey("CallTrakID");

                    b.HasIndex("ClientID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("StatusID");

                    b.HasIndex("TypeID");

                    b.ToTable("CallTraks");

                    b.HasData(
                        new
                        {
                            CallTrakID = 1,
                            ActionContents = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"",
                            ClientID = 1,
                            DescriptionContents = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            EmployeeID = 2,
                            StatusID = 3,
                            TypeID = 5
                        },
                        new
                        {
                            CallTrakID = 2,
                            ActionContents = "Havent done much",
                            BillingNotesContents = "$500000",
                            ClientID = 2,
                            DescriptionContents = "Calltrak 2",
                            DevNotesContents = "some dev notes",
                            EmployeeID = 1,
                            StatusID = 1,
                            TypeID = 6
                        },
                        new
                        {
                            CallTrakID = 3,
                            ActionContents = "We are just starting",
                            BillingNotesContents = "Free",
                            ClientID = 4,
                            DescriptionContents = "another Calltrack",
                            DevNotesContents = "hope this works",
                            EmployeeID = 1,
                            StatusID = 2,
                            TypeID = 2
                        });
                });

            modelBuilder.Entity("CallTrak_System.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientID = 1,
                            Name = "SiverCreek Software"
                        },
                        new
                        {
                            ClientID = 2,
                            Name = "Amazon Produce Network"
                        },
                        new
                        {
                            ClientID = 3,
                            Name = "Farm Art"
                        },
                        new
                        {
                            ClientID = 4,
                            Name = "Idaho State Liquor"
                        });
                });

            modelBuilder.Entity("CallTrak_System.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            FirstName = "Administrator",
                            IsAdmin = true,
                            LastName = "",
                            Password = "admn",
                            UserName = "admn"
                        },
                        new
                        {
                            EmployeeID = 2,
                            FirstName = "Matt",
                            IsAdmin = false,
                            LastName = "Tarpley",
                            Password = "Torrance67!",
                            UserName = "mtarpley"
                        });
                });

            modelBuilder.Entity("CallTrak_System.Models.Hours", b =>
                {
                    b.Property<int>("HoursID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HoursID"));

                    b.Property<int>("CallTrakID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<double?>("HoursWorked")
                        .HasColumnType("float");

                    b.HasKey("HoursID");

                    b.HasIndex("CallTrakID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("HTran");
                });

            modelBuilder.Entity("CallTrak_System.Models.Status", b =>
                {
                    b.Property<int?>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("StatusID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusID = 1,
                            Description = "Open"
                        },
                        new
                        {
                            StatusID = 2,
                            Description = "Complete"
                        },
                        new
                        {
                            StatusID = 3,
                            Description = "In Progress"
                        },
                        new
                        {
                            StatusID = 4,
                            Description = "To be Assigned"
                        },
                        new
                        {
                            StatusID = 5,
                            Description = "Archived"
                        },
                        new
                        {
                            StatusID = 6,
                            Description = "In Review"
                        });
                });

            modelBuilder.Entity("CallTrak_System.Models.Type", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeID");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            TypeID = 1,
                            Description = "SUPP CONT"
                        },
                        new
                        {
                            TypeID = 2,
                            Description = "MOD"
                        },
                        new
                        {
                            TypeID = 3,
                            Description = "ESTIMATE"
                        },
                        new
                        {
                            TypeID = 4,
                            Description = "FIX"
                        },
                        new
                        {
                            TypeID = 5,
                            Description = "GENERAL"
                        },
                        new
                        {
                            TypeID = 6,
                            Description = "NEW INSTALL"
                        });
                });

            modelBuilder.Entity("CallTrak_System.Models.CallTrak", b =>
                {
                    b.HasOne("CallTrak_System.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CallTrak_System.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CallTrak_System.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CallTrak_System.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");

                    b.Navigation("Status");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("CallTrak_System.Models.Hours", b =>
                {
                    b.HasOne("CallTrak_System.Models.CallTrak", "CallTrak")
                        .WithMany()
                        .HasForeignKey("CallTrakID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CallTrak_System.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CallTrak");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}