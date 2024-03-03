using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class fixTicketEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeatId",
                table: "Tickets",
                newName: "SeatNumber");

            migrationBuilder.AddColumn<string>(
                name: "Movie",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RowNumber",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TheaterName",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Movie",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "RowNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TheaterName",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "SeatNumber",
                table: "Tickets",
                newName: "SeatId");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 2, 13, 55, 41, 542, DateTimeKind.Local).AddTicks(5260));
        }
    }
}
