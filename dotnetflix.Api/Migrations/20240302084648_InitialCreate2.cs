using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ShowTime",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "TheaterName",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "RowNumber",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "SeatNumber",
                table: "Tickets",
                newName: "SeatId");

            migrationBuilder.RenameColumn(
                name: "BasePrice",
                table: "Tickets",
                newName: "TicketPrice");

            migrationBuilder.AddColumn<int>(
                name: "BasePrice",
                table: "Shows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BasePrice", "Date" },
                values: new object[] { 0, new DateTime(2024, 3, 2, 12, 46, 48, 429, DateTimeKind.Local).AddTicks(2880) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "Shows");

            migrationBuilder.RenameColumn(
                name: "TicketPrice",
                table: "Tickets",
                newName: "BasePrice");

            migrationBuilder.RenameColumn(
                name: "SeatId",
                table: "Tickets",
                newName: "SeatNumber");

            migrationBuilder.AddColumn<int>(
                name: "RowNumber",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShowTime",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TheaterName",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RowNumber",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 41,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 42,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 43,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 44,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 45,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 46,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 47,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 48,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 49,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 50,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 51,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 52,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 53,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 54,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 55,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 56,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 57,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 58,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 59,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 60,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 61,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 62,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 63,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 64,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 65,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 66,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 67,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 68,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 69,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 70,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 71,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 72,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 73,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 74,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 75,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 76,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 77,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 78,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 79,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 80,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 81,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 82,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 83,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 84,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 85,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 86,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 87,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 88,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 89,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 90,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 91,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 92,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 93,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 94,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 95,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 96,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 97,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 98,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 99,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 100,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 101,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 102,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 103,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 104,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 105,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 106,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 107,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 108,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 109,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 110,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 111,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 112,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 113,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 114,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 115,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 116,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 117,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 118,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 119,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 120,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 121,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 122,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 123,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 124,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 125,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 126,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 127,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 128,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 129,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 130,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 131,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 132,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 133,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 134,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 135,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 136,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 137,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 138,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 139,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 140,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 141,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 142,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 143,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 144,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 145,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 146,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 147,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 148,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 149,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 150,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 151,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 152,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 153,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 154,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 155,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 156,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 157,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 158,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 159,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 160,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 161,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 162,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 163,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 164,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 165,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 166,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 167,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 168,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 169,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 170,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 171,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 172,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 173,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 174,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 175,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 176,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 177,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 178,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 179,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 180,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 181,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 182,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 183,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 184,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 185,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 186,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 187,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 188,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 189,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 190,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 191,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 192,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 193,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 194,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 195,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 196,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 197,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 198,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 199,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 200,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 201,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 202,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 203,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 204,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 205,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 206,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 207,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 208,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 209,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 210,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 211,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 212,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 213,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 214,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 215,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 216,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 217,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 218,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 219,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 220,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 221,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 222,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 223,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 224,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 225,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 226,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 227,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 228,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 229,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 230,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 231,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 232,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 233,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 234,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 235,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 236,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 237,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 238,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 239,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 240,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 241,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 242,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 243,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 244,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 245,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 246,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 247,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 248,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 249,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 250,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 251,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 252,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 253,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 254,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 255,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 256,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 257,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 258,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 259,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 260,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 261,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 262,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 263,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 264,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 265,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 266,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 267,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 268,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 269,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 270,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 271,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 272,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 273,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 274,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 275,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 276,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 277,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 278,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 279,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 280,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 281,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 282,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 283,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 284,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 285,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 286,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 287,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 288,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 289,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 290,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 291,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 292,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 293,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 294,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 295,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 296,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 297,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 298,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 299,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 300,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 301,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 302,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 303,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 304,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 305,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 306,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 307,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 308,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 309,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 310,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 311,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 312,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 313,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 314,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 315,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 316,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 317,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 318,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 319,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 320,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 321,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 322,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 323,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 324,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 325,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 326,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 327,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 328,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 329,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 330,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 331,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 332,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 333,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 334,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 335,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 336,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 337,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 338,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 339,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 340,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 341,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 342,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 343,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 344,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 345,
                column: "RowNumber",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 346,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 347,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 348,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 349,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 350,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 351,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 352,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 353,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 354,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 355,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 356,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 357,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 358,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 359,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 360,
                column: "RowNumber",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 361,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 362,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 363,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 364,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 365,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 366,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 367,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 368,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 369,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 370,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 371,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 372,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 373,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 374,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 375,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 376,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 377,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 378,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 379,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 380,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 381,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 382,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 383,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 384,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 385,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 386,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 387,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 388,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 389,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 390,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 391,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 392,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 393,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 394,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 395,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 396,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 397,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 398,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 399,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 400,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 401,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 402,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 403,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 404,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 405,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 406,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 407,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 408,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 409,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 410,
                column: "RowNumber",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 411,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 412,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 413,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 414,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 415,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 416,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 417,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 418,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 419,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 420,
                column: "RowNumber",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 421,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 422,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 423,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 424,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 425,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 426,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 427,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 428,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 429,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 430,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 431,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 432,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 433,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 434,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 435,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 436,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 437,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 438,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 439,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 440,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 441,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 442,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 443,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 444,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 445,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 446,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 447,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 448,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 449,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 450,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 451,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 452,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 453,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 454,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 455,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 456,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 457,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 458,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 459,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 460,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 461,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 462,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 463,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 464,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 465,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 466,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 467,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 468,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 469,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 470,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 471,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 472,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 473,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 474,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 475,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 476,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 477,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 478,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 479,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 480,
                column: "RowNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 481,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 482,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 483,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 484,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 485,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 486,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 487,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 488,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 489,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 490,
                column: "RowNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 491,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 492,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 493,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 494,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 495,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 496,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 497,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 498,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 499,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 500,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 501,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 502,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 503,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 504,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 505,
                column: "RowNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 506,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 507,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 508,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 509,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 510,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 511,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 512,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 513,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 514,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 515,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 516,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 517,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 518,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 519,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 520,
                column: "RowNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(480));
        }
    }
}
