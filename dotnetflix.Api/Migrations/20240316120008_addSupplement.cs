using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class addSupplement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TicketTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.CreateTable(
                name: "Supplements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplements", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 16, 16, 0, 8, 197, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.InsertData(
                table: "Supplements",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Large popcorn", 3.00m },
                    { 2, "Large M&Ms", 4.00m },
                    { 3, "Large popcorn", 1.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplements");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Uuid",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "Id", "Discount", "Name" },
                values: new object[] { 6, 0m, "3D" });
        }
    }
}
