using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class fixSupplements2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Supplements",
                table: "Tickets");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Supplements",
                type: "decimal(6,2)",
                precision: 6,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Supplements",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BasePrice",
                table: "Shows",
                type: "decimal(6,2)",
                precision: 6,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 17, 16, 20, 39, 677, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Supplements",
                keyColumn: "Id",
                keyValue: 1,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Supplements",
                keyColumn: "Id",
                keyValue: 2,
                column: "TicketId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Supplements",
                keyColumn: "Id",
                keyValue: 3,
                column: "TicketId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Supplements_TicketId",
                table: "Supplements",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Supplements_Tickets_TicketId",
                table: "Supplements",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplements_Tickets_TicketId",
                table: "Supplements");

            migrationBuilder.DropIndex(
                name: "IX_Supplements_TicketId",
                table: "Supplements");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Supplements");

            migrationBuilder.AddColumn<string>(
                name: "Supplements",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Supplements",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)",
                oldPrecision: 6,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "BasePrice",
                table: "Shows",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)",
                oldPrecision: 6,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 627, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 17, 2, 46, 55, 628, DateTimeKind.Local).AddTicks(70));
        }
    }
}
