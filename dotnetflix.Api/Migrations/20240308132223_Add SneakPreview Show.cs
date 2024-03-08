using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSneakPreviewShow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SneakPreview",
                table: "Shows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5720), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5760), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5770), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5780), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5790), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5800), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5810), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5810), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5820), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5830), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5840), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5850), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5850), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5860), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5870), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5880), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5880), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5930), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5940), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5950), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5950), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5960), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5970), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5980), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5980), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(5990), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(6000), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(6010), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(6020), false });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "SneakPreview" },
                values: new object[] { new DateTime(2024, 3, 8, 17, 22, 23, 137, DateTimeKind.Local).AddTicks(6020), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SneakPreview",
                table: "Shows");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 3, 7, 22, 17, 17, 133, DateTimeKind.Local).AddTicks(8210));
        }
    }
}
