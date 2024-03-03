using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class fixTicketEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ShowTime",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowTime",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 2, 14, 38, 5, 166, DateTimeKind.Local).AddTicks(7110));
        }
    }
}
