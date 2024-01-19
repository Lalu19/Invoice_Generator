using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class eohuygv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<string>(nullable: true),
                    InvoiceLogo = table.Column<string>(nullable: true),
                    BillFrom = table.Column<string>(nullable: true),
                    BillTo = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    PaymentTerm = table.Column<string>(nullable: true),
                    PoNumber = table.Column<string>(nullable: true),
                    SubTotal = table.Column<double>(nullable: false),
                    Discounts = table.Column<double>(nullable: false),
                    Vat = table.Column<double>(nullable: false),
                    GrandTotal = table.Column<double>(nullable: false),
                    AmountPaid = table.Column<double>(nullable: false),
                    BalanceDue = table.Column<double>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Terms = table.Column<string>(nullable: true),
                    QRCode = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2023, 9, 25, 13, 34, 55, 48, DateTimeKind.Local).AddTicks(8037)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "SubInvoice",
                columns: table => new
                {
                    SubInvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(nullable: false),
                    ItemDetails = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Rate = table.Column<double>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2023, 9, 25, 13, 34, 55, 48, DateTimeKind.Local).AddTicks(9623)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubInvoice", x => x.SubInvoiceId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 43, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 38, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 39, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 44, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 41, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 41, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 41, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 34, 55, 41, DateTimeKind.Local).AddTicks(9952));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "SubInvoice");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 44, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 38, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 39, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 45, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 41, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 42, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 42, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 25, 13, 24, 17, 43, DateTimeKind.Local).AddTicks(672));
        }
    }
}
