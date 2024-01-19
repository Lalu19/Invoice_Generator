﻿// <auto-generated />
using System;
using AdminApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdminApi.Data
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230928102447_Invoiceeejeeehgee")]
    partial class Invoiceeejeeehgee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminApi.Models.App.Invoice.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("AmountPaid")
                        .HasColumnType("float");

                    b.Property<double>("BalanceDue")
                        .HasColumnType("float");

                    b.Property<string>("BillFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 28, 15, 54, 46, 747, DateTimeKind.Local).AddTicks(4524));

                    b.Property<double?>("Discounts")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("GrandTotal")
                        .HasColumnType("float");

                    b.Property<DateTime?>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QRCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<string>("Terms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Vat")
                        .HasColumnType("float");

                    b.HasKey("InvoiceId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("AdminApi.Models.App.Invoice.SubInvoice", b =>
                {
                    b.Property<int>("SubInvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 28, 15, 54, 46, 753, DateTimeKind.Local).AddTicks(74));

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("ItemDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("SubInvoiceId");

                    b.ToTable("SubInvoice");
                });

            modelBuilder.Entity("AdminApi.Models.Menu.AppMenu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'11', '1', '', '', 'False', '1'")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("IconClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMigrationData")
                        .HasColumnType("bit");

                    b.Property<int>("IsSubMenu")
                        .HasColumnType("int");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MenuTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ParentID")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("MenuID");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            MenuID = 1,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(6183),
                            IconClass = "fas fa-home",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 0,
                            MenuTitle = "Dashboard",
                            ParentID = 0,
                            SortOrder = 1,
                            URL = "/DashBoard/Index"
                        },
                        new
                        {
                            MenuID = 2,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7933),
                            IconClass = "fas fa-ellipsis-v",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 1,
                            MenuTitle = "Menu",
                            ParentID = 0,
                            SortOrder = 2,
                            URL = ""
                        },
                        new
                        {
                            MenuID = 3,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7944),
                            IconClass = "",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 0,
                            MenuTitle = "Menu List",
                            ParentID = 2,
                            SortOrder = 0,
                            URL = "/Menu/MenuList"
                        },
                        new
                        {
                            MenuID = 4,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7948),
                            IconClass = "",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 0,
                            MenuTitle = "Menu Group List",
                            ParentID = 2,
                            SortOrder = 0,
                            URL = "/Menu/MenuGroupList"
                        },
                        new
                        {
                            MenuID = 5,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7951),
                            IconClass = "fas fa-user",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 1,
                            MenuTitle = "User",
                            ParentID = 0,
                            SortOrder = 3,
                            URL = ""
                        },
                        new
                        {
                            MenuID = 6,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7955),
                            IconClass = "",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 0,
                            MenuTitle = "User List",
                            ParentID = 5,
                            SortOrder = 0,
                            URL = "/User/UserList"
                        },
                        new
                        {
                            MenuID = 7,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7958),
                            IconClass = "",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 0,
                            MenuTitle = "Role List",
                            ParentID = 5,
                            SortOrder = 0,
                            URL = "/User/RoleList"
                        },
                        new
                        {
                            MenuID = 8,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7961),
                            IconClass = "",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 0,
                            MenuTitle = "Profile",
                            ParentID = 5,
                            SortOrder = 0,
                            URL = "/User/UserProfile"
                        },
                        new
                        {
                            MenuID = 9,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7965),
                            IconClass = "fas fa-wrench",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 1,
                            MenuTitle = "Settings",
                            ParentID = 0,
                            SortOrder = 4,
                            URL = ""
                        },
                        new
                        {
                            MenuID = 10,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7968),
                            IconClass = "",
                            IsActive = true,
                            IsMigrationData = true,
                            IsSubMenu = 0,
                            MenuTitle = "Change Password",
                            ParentID = 9,
                            SortOrder = 0,
                            URL = "/User/ChangePassword"
                        });
                });

            modelBuilder.Entity("AdminApi.Models.Menu.MenuGroup", b =>
                {
                    b.Property<int>("MenuGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'3', '1', '', '', 'False', '1'")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMigrationData")
                        .HasColumnType("bit");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MenuGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MenuGroupID");

                    b.ToTable("MenuGroup");

                    b.HasData(
                        new
                        {
                            MenuGroupID = 1,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 734, DateTimeKind.Local).AddTicks(346),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupName = "Super Admin Group"
                        },
                        new
                        {
                            MenuGroupID = 2,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 735, DateTimeKind.Local).AddTicks(3501),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupName = "User Group"
                        });
                });

            modelBuilder.Entity("AdminApi.Models.Menu.MenuGroupWiseMenuMapping", b =>
                {
                    b.Property<int>("MenuGroupWiseMenuMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'11', '1', '', '', 'False', '1'")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMigrationData")
                        .HasColumnType("bit");

                    b.Property<int>("MenuGroupId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.HasKey("MenuGroupWiseMenuMappingId");

                    b.ToTable("MenuGroupWiseMenuMapping");

                    b.HasData(
                        new
                        {
                            MenuGroupWiseMenuMappingId = 1,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(4774),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 1,
                            MenuId = 1
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 2,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6728),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 1,
                            MenuId = 3
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 3,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6739),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 1,
                            MenuId = 4
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 4,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6743),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 1,
                            MenuId = 6
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 5,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6746),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 1,
                            MenuId = 7
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 6,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6749),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 1,
                            MenuId = 8
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 7,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6753),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 1,
                            MenuId = 10
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 8,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6756),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 2,
                            MenuId = 1
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 9,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6759),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 2,
                            MenuId = 8
                        },
                        new
                        {
                            MenuGroupWiseMenuMappingId = 10,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6762),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 2,
                            MenuId = 10
                        });
                });

            modelBuilder.Entity("AdminApi.Models.User.LogHistory", b =>
                {
                    b.Property<long>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LogCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LogInTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LogOutTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LogId");

                    b.ToTable("LogHistory");
                });

            modelBuilder.Entity("AdminApi.Models.User.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'3', '1', '', '', 'False', '1'")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMigrationData")
                        .HasColumnType("bit");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenuGroupId")
                        .HasColumnType("int");

                    b.Property<string>("RoleDesc")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("UserRoleId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            UserRoleId = 1,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 738, DateTimeKind.Local).AddTicks(2023),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            UserRoleId = 2,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 738, DateTimeKind.Local).AddTicks(3274),
                            IsActive = true,
                            IsMigrationData = true,
                            MenuGroupId = 2,
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("AdminApi.Models.User.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:IdentitySequenceOptions", "'3', '1', '', '', 'False', '1'")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMigrationData")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPasswordChange")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastPasswordChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("PasswordChangedBy")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 739, DateTimeKind.Local).AddTicks(8592),
                            FullName = "Appman",
                            IsActive = true,
                            IsMigrationData = true,
                            IsPasswordChange = false,
                            Password = "Appman@2019",
                            UserName = "developer",
                            UserRoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            AddedBy = 1,
                            DateAdded = new DateTime(2023, 9, 28, 15, 54, 46, 740, DateTimeKind.Local).AddTicks(988),
                            FullName = "Helen Smith",
                            IsActive = true,
                            IsMigrationData = true,
                            IsPasswordChange = false,
                            Password = "user@2020",
                            UserName = "user@2020",
                            UserRoleId = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
