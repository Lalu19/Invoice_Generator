using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Invoiceeejeegjhehgee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SubInvoice",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 28, 20, 34, 34, 107, DateTimeKind.Local).AddTicks(2057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 28, 15, 54, 46, 753, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Invoice",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 28, 20, 34, 34, 102, DateTimeKind.Local).AddTicks(3547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 28, 15, 54, 46, 747, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 99, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 90, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 91, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 101, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 94, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 95, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 96, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 28, 20, 34, 34, 96, DateTimeKind.Local).AddTicks(8664));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "SubInvoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 28, 15, 54, 46, 753, DateTimeKind.Local).AddTicks(74),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 28, 20, 34, 34, 107, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Invoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 28, 15, 54, 46, 747, DateTimeKind.Local).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 28, 20, 34, 34, 102, DateTimeKind.Local).AddTicks(3547));

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
    }
}
