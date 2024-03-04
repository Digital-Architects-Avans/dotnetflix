using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class fixTicketEntity3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 54, 38, 793, DateTimeKind.Local).AddTicks(4740));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 43, 58, 452, DateTimeKind.Local).AddTicks(4810));
        }
    }
}
