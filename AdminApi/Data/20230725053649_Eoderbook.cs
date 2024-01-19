using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Eoderbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentName = table.Column<string>(nullable: true),
                    AgentPhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PinCode = table.Column<string>(nullable: true),
                    ProfilePhoto = table.Column<string>(nullable: true),
                    AgentuserId = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentId);
                });

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    AreaName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "Beats",
                columns: table => new
                {
                    BeatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaId = table.Column<int>(nullable: false),
                    BeatName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beats", x => x.BeatId);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(nullable: true),
                    CountryName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "CreditHistory",
                columns: table => new
                {
                    CreditHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(nullable: false),
                    CreditBalance = table.Column<string>(nullable: true),
                    DebitBalance = table.Column<string>(nullable: true),
                    TransactionID = table.Column<string>(nullable: true),
                    TotalOutstanding = table.Column<string>(nullable: true),
                    TransactionStatus = table.Column<string>(nullable: true),
                    Receipt = table.Column<string>(nullable: true),
                    AgentId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditHistory", x => x.CreditHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(nullable: false),
                    DistrictName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "LogHistory",
                columns: table => new
                {
                    LogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogCode = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    LogInTime = table.Column<DateTime>(nullable: false),
                    LogOutTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogHistory", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: false),
                    MenuTitle = table.Column<string>(maxLength: 100, nullable: false),
                    URL = table.Column<string>(maxLength: 500, nullable: true),
                    IsSubMenu = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    IconClass = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    MenuGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupName = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroup", x => x.MenuGroupID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroupWiseMenuMapping",
                columns: table => new
                {
                    MenuGroupWiseMenuMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupId = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroupWiseMenuMapping", x => x.MenuGroupWiseMenuMappingId);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Carton = table.Column<int>(nullable: false),
                    piece = table.Column<int>(nullable: false),
                    ProductDetailsId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.OrderProductId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoOrderId = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    AgentId = table.Column<int>(nullable: false),
                    ShopImage = table.Column<string>(nullable: true),
                    ShopStatus = table.Column<string>(nullable: true),
                    OrederDateTime = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetailss",
                columns: table => new
                {
                    ProductDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false),
                    ProductDetailsName = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    MRP = table.Column<string>(nullable: true),
                    SellingPrice = table.Column<string>(nullable: true),
                    PackagingType = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetailss", x => x.ProductDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(nullable: false),
                    StateName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<int>(nullable: false),
                    BeatId = table.Column<int>(nullable: false),
                    StoreName = table.Column<string>(nullable: true),
                    OwnerName = table.Column<string>(nullable: true),
                    ContactPersonName = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    PinCode = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    WhatsAppNumber = table.Column<string>(nullable: true),
                    Landmark = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    CreditBalance = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "UserAssigns",
                columns: table => new
                {
                    UserAssignId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    AreaId = table.Column<int>(nullable: false),
                    BeatId = table.Column<int>(nullable: false),
                    BeatCoadId = table.Column<int>(nullable: false),
                    AssignDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssigns", x => x.UserAssignId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    RoleDesc = table.Column<string>(maxLength: 500, nullable: true),
                    MenuGroupId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 500, nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    LastPasswordChangeDate = table.Column<DateTime>(nullable: true),
                    PasswordChangedBy = table.Column<int>(nullable: true),
                    IsPasswordChange = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "AddedBy", "DateAdded", "IconClass", "IsActive", "IsMigrationData", "IsSubMenu", "LastUpdatedBy", "LastUpdatedDate", "MenuTitle", "ParentID", "SortOrder", "URL" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8344), "fas fa-home", true, true, 0, null, null, "Dashboard", 0, 1, "/DashBoard/Index" },
                    { 10, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8888), "", true, true, 0, null, null, "Change Password", 9, 0, "/User/ChangePassword" },
                    { 8, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8884), "", true, true, 0, null, null, "Profile", 5, 0, "/User/UserProfile" },
                    { 7, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8882), "", true, true, 0, null, null, "Role List", 5, 0, "/User/RoleList" },
                    { 6, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8880), "", true, true, 0, null, null, "User List", 5, 0, "/User/UserList" },
                    { 9, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8886), "fas fa-wrench", true, true, 1, null, null, "Settings", 0, 4, "" },
                    { 4, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8877), "", true, true, 0, null, null, "Menu Group List", 2, 0, "/Menu/MenuGroupList" },
                    { 3, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8875), "", true, true, 0, null, null, "Menu List", 2, 0, "/Menu/MenuList" },
                    { 2, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8871), "fas fa-ellipsis-v", true, true, 1, null, null, "Menu", 0, 2, "" },
                    { 5, 1, new DateTime(2023, 7, 25, 11, 6, 49, 415, DateTimeKind.Local).AddTicks(8879), "fas fa-user", true, true, 1, null, null, "User", 0, 3, "" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroup",
                columns: new[] { "MenuGroupID", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 25, 11, 6, 49, 410, DateTimeKind.Local).AddTicks(8176), true, true, null, null, "Super Admin Group" },
                    { 2, 1, new DateTime(2023, 7, 25, 11, 6, 49, 412, DateTimeKind.Local).AddTicks(1278), true, true, null, null, "User Group" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroupWiseMenuMapping",
                columns: new[] { "MenuGroupWiseMenuMappingId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "MenuGroupId", "MenuId" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7835), true, true, 1, 10 },
                    { 10, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7840), true, true, 2, 10 },
                    { 9, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7838), true, true, 2, 8 },
                    { 8, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7837), true, true, 2, 1 },
                    { 6, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7833), true, true, 1, 8 },
                    { 1, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7288), true, true, 1, 1 },
                    { 4, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7830), true, true, 1, 6 },
                    { 3, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7828), true, true, 1, 4 },
                    { 2, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7824), true, true, 1, 3 },
                    { 5, 1, new DateTime(2023, 7, 25, 11, 6, 49, 416, DateTimeKind.Local).AddTicks(7832), true, true, 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupId", "RoleDesc", "RoleName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 25, 11, 6, 49, 413, DateTimeKind.Local).AddTicks(9063), true, true, null, null, 1, null, "Admin" },
                    { 2, 1, new DateTime(2023, 7, 25, 11, 6, 49, 413, DateTimeKind.Local).AddTicks(9746), true, true, null, null, 2, null, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddedBy", "DateAdded", "DateOfBirth", "Email", "FullName", "ImagePath", "IsActive", "IsMigrationData", "IsPasswordChange", "LastPasswordChangeDate", "LastUpdatedBy", "LastUpdatedDate", "Mobile", "Password", "PasswordChangedBy", "UserName", "UserRoleId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 25, 11, 6, 49, 414, DateTimeKind.Local).AddTicks(7131), null, null, "Appman", null, true, true, false, null, null, null, null, "Appman@2019", null, "developer", 1 },
                    { 2, 1, new DateTime(2023, 7, 25, 11, 6, 49, 414, DateTimeKind.Local).AddTicks(7898), null, null, "Helen Smith", null, true, true, false, null, null, null, null, "user@2020", null, "user@2020", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Beats");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CreditHistory");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "LogHistory");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.DropTable(
                name: "MenuGroupWiseMenuMapping");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductDetailss");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "UserAssigns");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
