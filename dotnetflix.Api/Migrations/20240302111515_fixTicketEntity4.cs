using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class fixTicketEntity4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "BasePrice",
                table: "Shows",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0m, new DateTime(2024, 3, 2, 15, 15, 14, 919, DateTimeKind.Local).AddTicks(1470) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BasePrice",
                table: "Shows",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4740) });
        }
    }
}
