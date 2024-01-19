using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Invoiceeejeeehgee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SubInvoice",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 28, 15, 54, 46, 753, DateTimeKind.Local).AddTicks(74),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 16, 55, 50, 932, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Invoice",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 28, 15, 54, 46, 747, DateTimeKind.Local).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 743, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 734, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 735, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 746, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 738, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 738, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 739, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 15, 54, 46, 740, DateTimeKind.Local).AddTicks(988));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SubInvoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 16, 55, 50, 932, DateTimeKind.Local).AddTicks(4422),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 28, 15, 54, 46, 753, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Invoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 27, 16, 55, 50, 928, DateTimeKind.Local).AddTicks(6460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 28, 15, 54, 46, 747, DateTimeKind.Local).AddTicks(4524));

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
    }
}
