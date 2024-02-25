using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnetflix.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Image", "Rating", "Runtime", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "interstellar.jpg", 2, 169, "Interstellar", 2014 },
                    { 2, "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", "thedarkknight.jpg", 3, 152, "The Dark Knight", 2008 },
                    { 3, "A thief who steals corporate secrets through dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", "inception.jpg", 3, 148, "Inception", 2010 },
                    { 4, "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.", "parasite.jpg", 4, 132, "Parasite", 2019 },
                    { 5, "After the devastating events of Avengers: Infinity War, the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.", "avengersendgame.jpg", 3, 181, "Avengers: Endgame", 2019 }
                });

            migrationBuilder.InsertData(
                table: "Theaters",
                columns: new[] { "Id", "Name", "Seats" },
                values: new object[,]
                {
                    { 1, "Theater 1", 120 },
                    { 2, "Theater 2", 120 },
                    { 3, "Theater 3", 120 },
                    { 4, "Theater 4", 60 },
                    { 5, "Theater 5", 50 },
                    { 6, "Theater 6", 50 }
                });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "BasePrice", "Date", "MovieId", "TheaterId", "Time", "Type" },
                values: new object[,]
                {
                    { 1, 12.00m, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 1, 1, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 2, 12.00m, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 1, 2, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 3, 12.00m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 1, 3, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 4, 12.00m, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 1, 4, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 5, 12.00m, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, 5, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 6, 12.00m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 1, 6, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 7, 14.00m, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 8, 14.00m, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 2, 2, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 9, 14.00m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 2, 3, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 10, 14.00m, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 2, 4, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 11, 14.00m, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 2, 5, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 12, 14.00m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 2, 6, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 13, 16.00m, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, 1, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 14, 16.00m, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, 2, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 15, 16.00m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 3, 3, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 16, 16.00m, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 3, 4, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 17, 16.00m, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 3, 5, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 18, 16.00m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 3, 6, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 19, 18.00m, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 4, 1, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 20, 18.00m, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 4, 2, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 21, 18.00m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 4, 3, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 22, 18.00m, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 4, 4, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 23, 18.00m, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 4, 5, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 24, 18.00m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 4, 6, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 25, 20.00m, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Local), 5, 1, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 26, 20.00m, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local), 5, 2, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 27, 20.00m, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local), 5, 3, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 28, 20.00m, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local), 5, 4, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 29, 20.00m, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local), 5, 5, new TimeSpan(0, 19, 0, 0, 0), 0 },
                    { 30, 20.00m, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local), 5, 6, new TimeSpan(0, 19, 0, 0, 0), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Theaters",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
