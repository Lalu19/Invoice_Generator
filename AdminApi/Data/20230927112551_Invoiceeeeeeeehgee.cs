using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Invoiceeeeeeeehgee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SubInvoice",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 16, 55, 50, 932, DateTimeKind.Local).AddTicks(4422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 15, 37, 33, 412, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "Invoice",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Invoice",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Invoice",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(6460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 15, 37, 33, 408, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.AlterColumn<double>(
                name: "AmountPaid",
                table: "Invoice",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 926, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 917, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 919, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 927, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 922, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 922, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 923, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 16, 55, 50, 923, DateTimeKind.Local).AddTicks(8191));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SubInvoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 15, 37, 33, 412, DateTimeKind.Local).AddTicks(5704),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 27, 16, 55, 50, 932, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "Invoice",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Invoice",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Invoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 15, 37, 33, 408, DateTimeKind.Local).AddTicks(5419),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.AlterColumn<double>(
                name: "AmountPaid",
                table: "Invoice",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 405, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 406, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 396, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 399, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 407, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 402, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 402, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 403, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 27, 15, 37, 33, 403, DateTimeKind.Local).AddTicks(8720));
        }
    }
}
