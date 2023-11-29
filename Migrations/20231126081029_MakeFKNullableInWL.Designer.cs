﻿// <auto-generated />
using System;
using CallTrak_System.Models.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CallTrak_System.Migrations
{
    [DbContext(typeof(CallTrakContext))]
    [Migration("20231126081029_MakeFKNullableInWL")]
    partial class MakeFKNullableInWL
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BeginCodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BeginTestDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BilledDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BillingNotesContents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CodeRevDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ConfirmedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionContents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DevEstHrs")
                        .HasColumnType("float");

                    b.Property<string>("DevNotesContents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndCodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTestDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("HoursBilled")
                        .HasColumnType("float");

                    b.Property<double>("HoursIn")
                        .HasColumnType("float");

                    b.Property<DateTime?>("InLiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("InTestDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBeginCode")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBeginTest")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBilled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCodeRev")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEndCode")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEndTest")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInLive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInTest")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReadyInstall")
                        .HasColumnType("bit");

                    b.Property<string>("MenuPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int?>("PriorityID")
                        .HasColumnType("int");

                    b.Property<double>("QuoteEstHrs")
                        .HasColumnType("float");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReadyInstallDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShortDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<int?>("TypeID")
                        .HasColumnType("int");

                    b.Property<int?>("VersionID")
                        .HasColumnType("int");

                    b.HasKey("CallTrakID");

                    b.HasIndex("ClientID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ModuleID");

                    b.HasIndex("PriorityID");

                    b.HasIndex("StatusID");

                    b.HasIndex("TypeID");

                    b.HasIndex("VersionID");

                    b.ToTable("CallTraks");

                    b.HasData(
                        new
                        {
                            CallTrakID = 1,
                            ActionContents = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"",
                            ClientID = 1,
                            DescriptionContents = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            DevEstHrs = 0.0,
                            EmployeeID = 2,
                            HoursBilled = 0.0,
                            HoursIn = 0.0,
                            IsApproved = false,
                            IsBeginCode = false,
                            IsBeginTest = false,
                            IsBilled = false,
                            IsCodeRev = false,
                            IsConfirmed = false,
                            IsEndCode = false,
                            IsEndTest = false,
                            IsInLive = false,
                            IsInTest = false,
                            IsReadyInstall = false,
                            QuoteEstHrs = 0.0,
                            Rate = 0.0,
                            ShortDesc = "Continuing on this project",
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
                            DevEstHrs = 0.0,
                            DevNotesContents = "some dev notes",
                            EmployeeID = 1,
                            HoursBilled = 0.0,
                            HoursIn = 0.0,
                            IsApproved = false,
                            IsBeginCode = false,
                            IsBeginTest = false,
                            IsBilled = false,
                            IsCodeRev = false,
                            IsConfirmed = false,
                            IsEndCode = false,
                            IsEndTest = false,
                            IsInLive = false,
                            IsInTest = false,
                            IsReadyInstall = false,
                            QuoteEstHrs = 0.0,
                            Rate = 0.0,
                            ShortDesc = "BOL to include net and gross weight",
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
                            DevEstHrs = 0.0,
                            DevNotesContents = "hope this works",
                            EmployeeID = 1,
                            HoursBilled = 0.0,
                            HoursIn = 0.0,
                            IsApproved = false,
                            IsBeginCode = false,
                            IsBeginTest = false,
                            IsBilled = false,
                            IsCodeRev = false,
                            IsConfirmed = false,
                            IsEndCode = false,
                            IsEndTest = false,
                            IsInLive = false,
                            IsInTest = false,
                            IsReadyInstall = false,
                            QuoteEstHrs = 0.0,
                            Rate = 0.0,
                            ShortDesc = "potran not being updated properly",
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

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientID = 1,
                            Alias = "SCS",
                            Name = "SiverCreek Software"
                        },
                        new
                        {
                            ClientID = 2,
                            Alias = "APN",
                            Name = "Amazon Produce Network"
                        },
                        new
                        {
                            ClientID = 3,
                            Alias = "FAA",
                            Name = "Farm Art"
                        },
                        new
                        {
                            ClientID = 4,
                            Alias = "ISLD",
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
                            LastName = "Administrator",
                            Password = "Admn1!",
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

            modelBuilder.Entity("CallTrak_System.Models.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModuleId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("CallTrak_System.Models.Priority", b =>
                {
                    b.Property<int>("PriorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriorityId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriorityId");

                    b.ToTable("Priorities");

                    b.HasData(
                        new
                        {
                            PriorityId = 1,
                            Description = "1 - HIGH"
                        },
                        new
                        {
                            PriorityId = 2,
                            Description = "3 - MED"
                        },
                        new
                        {
                            PriorityId = 3,
                            Description = "5 - LOW"
                        },
                        new
                        {
                            PriorityId = 4,
                            Description = "0 - CRIT"
                        });
                });

            modelBuilder.Entity("CallTrak_System.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"));

                    b.Property<string>("Description")
                        .IsRequired()
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
                        .IsRequired()
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
                            Description = "MERGE"
                        },
                        new
                        {
                            TypeID = 6,
                            Description = "NEW INSTALL"
                        },
                        new
                        {
                            TypeID = 7,
                            Description = "AFTER HOUR"
                        },
                        new
                        {
                            TypeID = 8,
                            Description = "DATA"
                        },
                        new
                        {
                            TypeID = 9,
                            Description = "SUPP BILL"
                        },
                        new
                        {
                            TypeID = 10,
                            Description = "TRAINING"
                        },
                        new
                        {
                            TypeID = 11,
                            Description = "UPGRADE"
                        },
                        new
                        {
                            TypeID = 12,
                            Description = "VP BASE"
                        });
                });

            modelBuilder.Entity("CallTrak_System.Models.Version", b =>
                {
                    b.Property<int>("VersionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VersionId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VersionId");

                    b.ToTable("Versions");
                });

            modelBuilder.Entity("CallTrak_System.Models.WorkLog", b =>
                {
                    b.Property<int>("WorkLogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkLogID"));

                    b.Property<int?>("CallTrakID")
                        .HasColumnType("int");

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateWorked")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<double>("HoursWorked")
                        .HasColumnType("float");

                    b.HasKey("WorkLogID");

                    b.HasIndex("CallTrakID");

                    b.HasIndex("ClientID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("WorkLogs");
                });

            modelBuilder.Entity("CallTrak_System.Models.CallTrak", b =>
                {
                    b.HasOne("CallTrak_System.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("CallTrak_System.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.HasOne("CallTrak_System.Models.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleID");

                    b.HasOne("CallTrak_System.Models.Priority", "Priority")
                        .WithMany()
                        .HasForeignKey("PriorityID");

                    b.HasOne("CallTrak_System.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CallTrak_System.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");

                    b.HasOne("CallTrak_System.Models.Version", "Version")
                        .WithMany()
                        .HasForeignKey("VersionID");

                    b.Navigation("Client");

                    b.Navigation("Employee");

                    b.Navigation("Module");

                    b.Navigation("Priority");

                    b.Navigation("Status");

                    b.Navigation("Type");

                    b.Navigation("Version");
                });

            modelBuilder.Entity("CallTrak_System.Models.WorkLog", b =>
                {
                    b.HasOne("CallTrak_System.Models.CallTrak", "CallTrak")
                        .WithMany("WorkLogs")
                        .HasForeignKey("CallTrakID");

                    b.HasOne("CallTrak_System.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.HasOne("CallTrak_System.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.Navigation("CallTrak");

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CallTrak_System.Models.CallTrak", b =>
                {
                    b.Navigation("WorkLogs");
                });
#pragma warning restore 612, 618
        }
    }
}