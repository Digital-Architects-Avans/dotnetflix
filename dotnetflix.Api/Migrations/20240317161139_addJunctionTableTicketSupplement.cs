using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class addJunctionTableTicketSupplement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "TicketSupplements",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    SupplementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketSupplements", x => new { x.TicketId, x.SupplementId });
                    table.ForeignKey(
                        name: "FK_TicketSupplements_Supplements_SupplementId",
                        column: x => x.SupplementId,
                        principalTable: "Supplements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketSupplements_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 17, 20, 11, 39, 262, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.CreateIndex(
                name: "IX_TicketSupplements_SupplementId",
                table: "TicketSupplements",
                column: "SupplementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketSupplements");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Supplements",
                type: "int",
                nullable: true);

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
    }
}
