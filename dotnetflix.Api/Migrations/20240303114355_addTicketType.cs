using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class addTicketType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "Tickets",
                newName: "TicketTypeId");

            migrationBuilder.CreateTable(
                name: "TicketTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 3, 15, 43, 55, 583, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.InsertData(
                table: "TicketTypes",
                columns: new[] { "Id", "Discount", "Name" },
                values: new object[,]
                {
                    { 1, 0m, "Normal" },
                    { 2, 1.50m, "Child" },
                    { 3, 1.50m, "Student" },
                    { 4, 1.50m, "Senior" },
                    { 5, 1.50m, "Cinema Pass" },
                    { 6, 0m, "3D" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketTypes");

            migrationBuilder.RenameColumn(
                name: "TicketTypeId",
                table: "Tickets",
                newName: "Discount");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 2, 16, 50, 8, 716, DateTimeKind.Local).AddTicks(3240));
        }
    }
}
