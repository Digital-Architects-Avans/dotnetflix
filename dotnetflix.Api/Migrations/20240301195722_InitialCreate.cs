using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnetflix.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Runtime = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theaters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theaters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    TheaterId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScreenTime = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shows_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shows_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TheaterRows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheaterId = table.Column<int>(type: "int", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheaterRows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TheaterRows_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ShowId = table.Column<int>(type: "int", nullable: false),
                    ShowTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TheaterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Shows_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheaterRowId = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_TheaterRows_TheaterRowId",
                        column: x => x.TheaterRowId,
                        principalTable: "TheaterRows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Id", "Date", "MovieId", "ScreenTime", "TheaterId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(120), 1, 90, 1, 0 },
                    { 2, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(190), 1, 90, 2, 0 },
                    { 3, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(200), 1, 90, 3, 0 },
                    { 4, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(210), 1, 90, 4, 0 },
                    { 5, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(220), 1, 90, 5, 0 },
                    { 6, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(230), 1, 90, 6, 0 },
                    { 7, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(240), 2, 90, 1, 0 },
                    { 8, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(250), 2, 90, 2, 0 },
                    { 9, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(270), 2, 90, 3, 0 },
                    { 10, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(280), 2, 90, 4, 0 },
                    { 11, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(290), 2, 90, 5, 0 },
                    { 12, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(300), 2, 90, 6, 0 },
                    { 13, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(310), 3, 90, 1, 0 },
                    { 14, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(320), 3, 90, 2, 0 },
                    { 15, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(330), 3, 90, 3, 0 },
                    { 16, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(340), 3, 90, 4, 0 },
                    { 17, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(350), 3, 90, 5, 0 },
                    { 18, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(360), 3, 90, 6, 0 },
                    { 19, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(370), 4, 90, 1, 0 },
                    { 20, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(380), 4, 90, 2, 0 },
                    { 21, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(390), 4, 90, 3, 0 },
                    { 22, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(400), 4, 90, 4, 0 },
                    { 23, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(410), 4, 90, 5, 0 },
                    { 24, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(420), 4, 90, 6, 0 },
                    { 25, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(430), 5, 90, 1, 0 },
                    { 26, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(440), 5, 90, 2, 0 },
                    { 27, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(450), 5, 90, 3, 0 },
                    { 28, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(460), 5, 90, 4, 0 },
                    { 29, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(470), 5, 90, 5, 0 },
                    { 30, new DateTime(2024, 3, 1, 23, 57, 22, 375, DateTimeKind.Local).AddTicks(480), 5, 90, 6, 0 }
                });

            migrationBuilder.InsertData(
                table: "TheaterRows",
                columns: new[] { "Id", "NumberOfSeats", "RowNumber", "TheaterId" },
                values: new object[,]
                {
                    { 1, 15, 1, 1 },
                    { 2, 15, 2, 1 },
                    { 3, 15, 3, 1 },
                    { 4, 15, 4, 1 },
                    { 5, 15, 5, 1 },
                    { 6, 15, 6, 1 },
                    { 7, 15, 7, 1 },
                    { 8, 15, 8, 1 },
                    { 9, 15, 1, 2 },
                    { 10, 15, 2, 2 },
                    { 11, 15, 3, 2 },
                    { 12, 15, 4, 2 },
                    { 13, 15, 5, 2 },
                    { 14, 15, 6, 2 },
                    { 15, 15, 7, 2 },
                    { 16, 15, 8, 2 },
                    { 17, 15, 1, 3 },
                    { 18, 15, 2, 3 },
                    { 19, 15, 3, 3 },
                    { 20, 15, 4, 3 },
                    { 21, 15, 5, 3 },
                    { 22, 15, 6, 3 },
                    { 23, 15, 7, 3 },
                    { 24, 15, 8, 3 },
                    { 25, 10, 1, 4 },
                    { 26, 10, 2, 4 },
                    { 27, 10, 3, 4 },
                    { 28, 10, 4, 4 },
                    { 29, 10, 5, 4 },
                    { 30, 10, 6, 4 },
                    { 31, 10, 1, 5 },
                    { 32, 10, 2, 5 },
                    { 33, 15, 3, 5 },
                    { 34, 15, 4, 5 },
                    { 35, 10, 1, 6 },
                    { 36, 10, 2, 6 },
                    { 37, 15, 3, 6 },
                    { 38, 15, 4, 6 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "RowNumber", "SeatNumber", "TheaterRowId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 2, 1 },
                    { 3, 1, 3, 1 },
                    { 4, 1, 4, 1 },
                    { 5, 1, 5, 1 },
                    { 6, 1, 6, 1 },
                    { 7, 1, 7, 1 },
                    { 8, 1, 8, 1 },
                    { 9, 1, 9, 1 },
                    { 10, 1, 10, 1 },
                    { 11, 1, 11, 1 },
                    { 12, 1, 12, 1 },
                    { 13, 1, 13, 1 },
                    { 14, 1, 14, 1 },
                    { 15, 1, 15, 1 },
                    { 16, 2, 1, 2 },
                    { 17, 2, 2, 2 },
                    { 18, 2, 3, 2 },
                    { 19, 2, 4, 2 },
                    { 20, 2, 5, 2 },
                    { 21, 2, 6, 2 },
                    { 22, 2, 7, 2 },
                    { 23, 2, 8, 2 },
                    { 24, 2, 9, 2 },
                    { 25, 2, 10, 2 },
                    { 26, 2, 11, 2 },
                    { 27, 2, 12, 2 },
                    { 28, 2, 13, 2 },
                    { 29, 2, 14, 2 },
                    { 30, 2, 15, 2 },
                    { 31, 3, 1, 3 },
                    { 32, 3, 2, 3 },
                    { 33, 3, 3, 3 },
                    { 34, 3, 4, 3 },
                    { 35, 3, 5, 3 },
                    { 36, 3, 6, 3 },
                    { 37, 3, 7, 3 },
                    { 38, 3, 8, 3 },
                    { 39, 3, 9, 3 },
                    { 40, 3, 10, 3 },
                    { 41, 3, 11, 3 },
                    { 42, 3, 12, 3 },
                    { 43, 3, 13, 3 },
                    { 44, 3, 14, 3 },
                    { 45, 3, 15, 3 },
                    { 46, 4, 1, 4 },
                    { 47, 4, 2, 4 },
                    { 48, 4, 3, 4 },
                    { 49, 4, 4, 4 },
                    { 50, 4, 5, 4 },
                    { 51, 4, 6, 4 },
                    { 52, 4, 7, 4 },
                    { 53, 4, 8, 4 },
                    { 54, 4, 9, 4 },
                    { 55, 4, 10, 4 },
                    { 56, 4, 11, 4 },
                    { 57, 4, 12, 4 },
                    { 58, 4, 13, 4 },
                    { 59, 4, 14, 4 },
                    { 60, 4, 15, 4 },
                    { 61, 5, 1, 5 },
                    { 62, 5, 2, 5 },
                    { 63, 5, 3, 5 },
                    { 64, 5, 4, 5 },
                    { 65, 5, 5, 5 },
                    { 66, 5, 6, 5 },
                    { 67, 5, 7, 5 },
                    { 68, 5, 8, 5 },
                    { 69, 5, 9, 5 },
                    { 70, 5, 10, 5 },
                    { 71, 5, 11, 5 },
                    { 72, 5, 12, 5 },
                    { 73, 5, 13, 5 },
                    { 74, 5, 14, 5 },
                    { 75, 5, 15, 5 },
                    { 76, 6, 1, 6 },
                    { 77, 6, 2, 6 },
                    { 78, 6, 3, 6 },
                    { 79, 6, 4, 6 },
                    { 80, 6, 5, 6 },
                    { 81, 6, 6, 6 },
                    { 82, 6, 7, 6 },
                    { 83, 6, 8, 6 },
                    { 84, 6, 9, 6 },
                    { 85, 6, 10, 6 },
                    { 86, 6, 11, 6 },
                    { 87, 6, 12, 6 },
                    { 88, 6, 13, 6 },
                    { 89, 6, 14, 6 },
                    { 90, 6, 15, 6 },
                    { 91, 7, 1, 7 },
                    { 92, 7, 2, 7 },
                    { 93, 7, 3, 7 },
                    { 94, 7, 4, 7 },
                    { 95, 7, 5, 7 },
                    { 96, 7, 6, 7 },
                    { 97, 7, 7, 7 },
                    { 98, 7, 8, 7 },
                    { 99, 7, 9, 7 },
                    { 100, 7, 10, 7 },
                    { 101, 7, 11, 7 },
                    { 102, 7, 12, 7 },
                    { 103, 7, 13, 7 },
                    { 104, 7, 14, 7 },
                    { 105, 7, 15, 7 },
                    { 106, 8, 1, 8 },
                    { 107, 8, 2, 8 },
                    { 108, 8, 3, 8 },
                    { 109, 8, 4, 8 },
                    { 110, 8, 5, 8 },
                    { 111, 8, 6, 8 },
                    { 112, 8, 7, 8 },
                    { 113, 8, 8, 8 },
                    { 114, 8, 9, 8 },
                    { 115, 8, 10, 8 },
                    { 116, 8, 11, 8 },
                    { 117, 8, 12, 8 },
                    { 118, 8, 13, 8 },
                    { 119, 8, 14, 8 },
                    { 120, 8, 15, 8 },
                    { 121, 1, 1, 9 },
                    { 122, 1, 2, 9 },
                    { 123, 1, 3, 9 },
                    { 124, 1, 4, 9 },
                    { 125, 1, 5, 9 },
                    { 126, 1, 6, 9 },
                    { 127, 1, 7, 9 },
                    { 128, 1, 8, 9 },
                    { 129, 1, 9, 9 },
                    { 130, 1, 10, 9 },
                    { 131, 1, 11, 9 },
                    { 132, 1, 12, 9 },
                    { 133, 1, 13, 9 },
                    { 134, 1, 14, 9 },
                    { 135, 1, 15, 9 },
                    { 136, 2, 1, 10 },
                    { 137, 2, 2, 10 },
                    { 138, 2, 3, 10 },
                    { 139, 2, 4, 10 },
                    { 140, 2, 5, 10 },
                    { 141, 2, 6, 10 },
                    { 142, 2, 7, 10 },
                    { 143, 2, 8, 10 },
                    { 144, 2, 9, 10 },
                    { 145, 2, 10, 10 },
                    { 146, 2, 11, 10 },
                    { 147, 2, 12, 10 },
                    { 148, 2, 13, 10 },
                    { 149, 2, 14, 10 },
                    { 150, 2, 15, 10 },
                    { 151, 3, 1, 11 },
                    { 152, 3, 2, 11 },
                    { 153, 3, 3, 11 },
                    { 154, 3, 4, 11 },
                    { 155, 3, 5, 11 },
                    { 156, 3, 6, 11 },
                    { 157, 3, 7, 11 },
                    { 158, 3, 8, 11 },
                    { 159, 3, 9, 11 },
                    { 160, 3, 10, 11 },
                    { 161, 3, 11, 11 },
                    { 162, 3, 12, 11 },
                    { 163, 3, 13, 11 },
                    { 164, 3, 14, 11 },
                    { 165, 3, 15, 11 },
                    { 166, 4, 1, 12 },
                    { 167, 4, 2, 12 },
                    { 168, 4, 3, 12 },
                    { 169, 4, 4, 12 },
                    { 170, 4, 5, 12 },
                    { 171, 4, 6, 12 },
                    { 172, 4, 7, 12 },
                    { 173, 4, 8, 12 },
                    { 174, 4, 9, 12 },
                    { 175, 4, 10, 12 },
                    { 176, 4, 11, 12 },
                    { 177, 4, 12, 12 },
                    { 178, 4, 13, 12 },
                    { 179, 4, 14, 12 },
                    { 180, 4, 15, 12 },
                    { 181, 5, 1, 13 },
                    { 182, 5, 2, 13 },
                    { 183, 5, 3, 13 },
                    { 184, 5, 4, 13 },
                    { 185, 5, 5, 13 },
                    { 186, 5, 6, 13 },
                    { 187, 5, 7, 13 },
                    { 188, 5, 8, 13 },
                    { 189, 5, 9, 13 },
                    { 190, 5, 10, 13 },
                    { 191, 5, 11, 13 },
                    { 192, 5, 12, 13 },
                    { 193, 5, 13, 13 },
                    { 194, 5, 14, 13 },
                    { 195, 5, 15, 13 },
                    { 196, 6, 1, 14 },
                    { 197, 6, 2, 14 },
                    { 198, 6, 3, 14 },
                    { 199, 6, 4, 14 },
                    { 200, 6, 5, 14 },
                    { 201, 6, 6, 14 },
                    { 202, 6, 7, 14 },
                    { 203, 6, 8, 14 },
                    { 204, 6, 9, 14 },
                    { 205, 6, 10, 14 },
                    { 206, 6, 11, 14 },
                    { 207, 6, 12, 14 },
                    { 208, 6, 13, 14 },
                    { 209, 6, 14, 14 },
                    { 210, 6, 15, 14 },
                    { 211, 7, 1, 15 },
                    { 212, 7, 2, 15 },
                    { 213, 7, 3, 15 },
                    { 214, 7, 4, 15 },
                    { 215, 7, 5, 15 },
                    { 216, 7, 6, 15 },
                    { 217, 7, 7, 15 },
                    { 218, 7, 8, 15 },
                    { 219, 7, 9, 15 },
                    { 220, 7, 10, 15 },
                    { 221, 7, 11, 15 },
                    { 222, 7, 12, 15 },
                    { 223, 7, 13, 15 },
                    { 224, 7, 14, 15 },
                    { 225, 7, 15, 15 },
                    { 226, 8, 1, 16 },
                    { 227, 8, 2, 16 },
                    { 228, 8, 3, 16 },
                    { 229, 8, 4, 16 },
                    { 230, 8, 5, 16 },
                    { 231, 8, 6, 16 },
                    { 232, 8, 7, 16 },
                    { 233, 8, 8, 16 },
                    { 234, 8, 9, 16 },
                    { 235, 8, 10, 16 },
                    { 236, 8, 11, 16 },
                    { 237, 8, 12, 16 },
                    { 238, 8, 13, 16 },
                    { 239, 8, 14, 16 },
                    { 240, 8, 15, 16 },
                    { 241, 1, 1, 17 },
                    { 242, 1, 2, 17 },
                    { 243, 1, 3, 17 },
                    { 244, 1, 4, 17 },
                    { 245, 1, 5, 17 },
                    { 246, 1, 6, 17 },
                    { 247, 1, 7, 17 },
                    { 248, 1, 8, 17 },
                    { 249, 1, 9, 17 },
                    { 250, 1, 10, 17 },
                    { 251, 1, 11, 17 },
                    { 252, 1, 12, 17 },
                    { 253, 1, 13, 17 },
                    { 254, 1, 14, 17 },
                    { 255, 1, 15, 17 },
                    { 256, 2, 1, 18 },
                    { 257, 2, 2, 18 },
                    { 258, 2, 3, 18 },
                    { 259, 2, 4, 18 },
                    { 260, 2, 5, 18 },
                    { 261, 2, 6, 18 },
                    { 262, 2, 7, 18 },
                    { 263, 2, 8, 18 },
                    { 264, 2, 9, 18 },
                    { 265, 2, 10, 18 },
                    { 266, 2, 11, 18 },
                    { 267, 2, 12, 18 },
                    { 268, 2, 13, 18 },
                    { 269, 2, 14, 18 },
                    { 270, 2, 15, 18 },
                    { 271, 3, 1, 19 },
                    { 272, 3, 2, 19 },
                    { 273, 3, 3, 19 },
                    { 274, 3, 4, 19 },
                    { 275, 3, 5, 19 },
                    { 276, 3, 6, 19 },
                    { 277, 3, 7, 19 },
                    { 278, 3, 8, 19 },
                    { 279, 3, 9, 19 },
                    { 280, 3, 10, 19 },
                    { 281, 3, 11, 19 },
                    { 282, 3, 12, 19 },
                    { 283, 3, 13, 19 },
                    { 284, 3, 14, 19 },
                    { 285, 3, 15, 19 },
                    { 286, 4, 1, 20 },
                    { 287, 4, 2, 20 },
                    { 288, 4, 3, 20 },
                    { 289, 4, 4, 20 },
                    { 290, 4, 5, 20 },
                    { 291, 4, 6, 20 },
                    { 292, 4, 7, 20 },
                    { 293, 4, 8, 20 },
                    { 294, 4, 9, 20 },
                    { 295, 4, 10, 20 },
                    { 296, 4, 11, 20 },
                    { 297, 4, 12, 20 },
                    { 298, 4, 13, 20 },
                    { 299, 4, 14, 20 },
                    { 300, 4, 15, 20 },
                    { 301, 5, 1, 21 },
                    { 302, 5, 2, 21 },
                    { 303, 5, 3, 21 },
                    { 304, 5, 4, 21 },
                    { 305, 5, 5, 21 },
                    { 306, 5, 6, 21 },
                    { 307, 5, 7, 21 },
                    { 308, 5, 8, 21 },
                    { 309, 5, 9, 21 },
                    { 310, 5, 10, 21 },
                    { 311, 5, 11, 21 },
                    { 312, 5, 12, 21 },
                    { 313, 5, 13, 21 },
                    { 314, 5, 14, 21 },
                    { 315, 5, 15, 21 },
                    { 316, 6, 1, 22 },
                    { 317, 6, 2, 22 },
                    { 318, 6, 3, 22 },
                    { 319, 6, 4, 22 },
                    { 320, 6, 5, 22 },
                    { 321, 6, 6, 22 },
                    { 322, 6, 7, 22 },
                    { 323, 6, 8, 22 },
                    { 324, 6, 9, 22 },
                    { 325, 6, 10, 22 },
                    { 326, 6, 11, 22 },
                    { 327, 6, 12, 22 },
                    { 328, 6, 13, 22 },
                    { 329, 6, 14, 22 },
                    { 330, 6, 15, 22 },
                    { 331, 7, 1, 23 },
                    { 332, 7, 2, 23 },
                    { 333, 7, 3, 23 },
                    { 334, 7, 4, 23 },
                    { 335, 7, 5, 23 },
                    { 336, 7, 6, 23 },
                    { 337, 7, 7, 23 },
                    { 338, 7, 8, 23 },
                    { 339, 7, 9, 23 },
                    { 340, 7, 10, 23 },
                    { 341, 7, 11, 23 },
                    { 342, 7, 12, 23 },
                    { 343, 7, 13, 23 },
                    { 344, 7, 14, 23 },
                    { 345, 7, 15, 23 },
                    { 346, 8, 1, 24 },
                    { 347, 8, 2, 24 },
                    { 348, 8, 3, 24 },
                    { 349, 8, 4, 24 },
                    { 350, 8, 5, 24 },
                    { 351, 8, 6, 24 },
                    { 352, 8, 7, 24 },
                    { 353, 8, 8, 24 },
                    { 354, 8, 9, 24 },
                    { 355, 8, 10, 24 },
                    { 356, 8, 11, 24 },
                    { 357, 8, 12, 24 },
                    { 358, 8, 13, 24 },
                    { 359, 8, 14, 24 },
                    { 360, 8, 15, 24 },
                    { 361, 1, 1, 25 },
                    { 362, 1, 2, 25 },
                    { 363, 1, 3, 25 },
                    { 364, 1, 4, 25 },
                    { 365, 1, 5, 25 },
                    { 366, 1, 6, 25 },
                    { 367, 1, 7, 25 },
                    { 368, 1, 8, 25 },
                    { 369, 1, 9, 25 },
                    { 370, 1, 10, 25 },
                    { 371, 2, 1, 26 },
                    { 372, 2, 2, 26 },
                    { 373, 2, 3, 26 },
                    { 374, 2, 4, 26 },
                    { 375, 2, 5, 26 },
                    { 376, 2, 6, 26 },
                    { 377, 2, 7, 26 },
                    { 378, 2, 8, 26 },
                    { 379, 2, 9, 26 },
                    { 380, 2, 10, 26 },
                    { 381, 3, 1, 27 },
                    { 382, 3, 2, 27 },
                    { 383, 3, 3, 27 },
                    { 384, 3, 4, 27 },
                    { 385, 3, 5, 27 },
                    { 386, 3, 6, 27 },
                    { 387, 3, 7, 27 },
                    { 388, 3, 8, 27 },
                    { 389, 3, 9, 27 },
                    { 390, 3, 10, 27 },
                    { 391, 4, 1, 28 },
                    { 392, 4, 2, 28 },
                    { 393, 4, 3, 28 },
                    { 394, 4, 4, 28 },
                    { 395, 4, 5, 28 },
                    { 396, 4, 6, 28 },
                    { 397, 4, 7, 28 },
                    { 398, 4, 8, 28 },
                    { 399, 4, 9, 28 },
                    { 400, 4, 10, 28 },
                    { 401, 5, 1, 29 },
                    { 402, 5, 2, 29 },
                    { 403, 5, 3, 29 },
                    { 404, 5, 4, 29 },
                    { 405, 5, 5, 29 },
                    { 406, 5, 6, 29 },
                    { 407, 5, 7, 29 },
                    { 408, 5, 8, 29 },
                    { 409, 5, 9, 29 },
                    { 410, 5, 10, 29 },
                    { 411, 6, 1, 30 },
                    { 412, 6, 2, 30 },
                    { 413, 6, 3, 30 },
                    { 414, 6, 4, 30 },
                    { 415, 6, 5, 30 },
                    { 416, 6, 6, 30 },
                    { 417, 6, 7, 30 },
                    { 418, 6, 8, 30 },
                    { 419, 6, 9, 30 },
                    { 420, 6, 10, 30 },
                    { 421, 1, 1, 31 },
                    { 422, 1, 2, 31 },
                    { 423, 1, 3, 31 },
                    { 424, 1, 4, 31 },
                    { 425, 1, 5, 31 },
                    { 426, 1, 6, 31 },
                    { 427, 1, 7, 31 },
                    { 428, 1, 8, 31 },
                    { 429, 1, 9, 31 },
                    { 430, 1, 10, 31 },
                    { 431, 2, 1, 32 },
                    { 432, 2, 2, 32 },
                    { 433, 2, 3, 32 },
                    { 434, 2, 4, 32 },
                    { 435, 2, 5, 32 },
                    { 436, 2, 6, 32 },
                    { 437, 2, 7, 32 },
                    { 438, 2, 8, 32 },
                    { 439, 2, 9, 32 },
                    { 440, 2, 10, 32 },
                    { 441, 3, 1, 33 },
                    { 442, 3, 2, 33 },
                    { 443, 3, 3, 33 },
                    { 444, 3, 4, 33 },
                    { 445, 3, 5, 33 },
                    { 446, 3, 6, 33 },
                    { 447, 3, 7, 33 },
                    { 448, 3, 8, 33 },
                    { 449, 3, 9, 33 },
                    { 450, 3, 10, 33 },
                    { 451, 3, 11, 33 },
                    { 452, 3, 12, 33 },
                    { 453, 3, 13, 33 },
                    { 454, 3, 14, 33 },
                    { 455, 3, 15, 33 },
                    { 456, 4, 1, 34 },
                    { 457, 4, 2, 34 },
                    { 458, 4, 3, 34 },
                    { 459, 4, 4, 34 },
                    { 460, 4, 5, 34 },
                    { 461, 4, 6, 34 },
                    { 462, 4, 7, 34 },
                    { 463, 4, 8, 34 },
                    { 464, 4, 9, 34 },
                    { 465, 4, 10, 34 },
                    { 466, 4, 11, 34 },
                    { 467, 4, 12, 34 },
                    { 468, 4, 13, 34 },
                    { 469, 4, 14, 34 },
                    { 470, 4, 15, 34 },
                    { 471, 1, 1, 35 },
                    { 472, 1, 2, 35 },
                    { 473, 1, 3, 35 },
                    { 474, 1, 4, 35 },
                    { 475, 1, 5, 35 },
                    { 476, 1, 6, 35 },
                    { 477, 1, 7, 35 },
                    { 478, 1, 8, 35 },
                    { 479, 1, 9, 35 },
                    { 480, 1, 10, 35 },
                    { 481, 2, 1, 36 },
                    { 482, 2, 2, 36 },
                    { 483, 2, 3, 36 },
                    { 484, 2, 4, 36 },
                    { 485, 2, 5, 36 },
                    { 486, 2, 6, 36 },
                    { 487, 2, 7, 36 },
                    { 488, 2, 8, 36 },
                    { 489, 2, 9, 36 },
                    { 490, 2, 10, 36 },
                    { 491, 3, 1, 37 },
                    { 492, 3, 2, 37 },
                    { 493, 3, 3, 37 },
                    { 494, 3, 4, 37 },
                    { 495, 3, 5, 37 },
                    { 496, 3, 6, 37 },
                    { 497, 3, 7, 37 },
                    { 498, 3, 8, 37 },
                    { 499, 3, 9, 37 },
                    { 500, 3, 10, 37 },
                    { 501, 3, 11, 37 },
                    { 502, 3, 12, 37 },
                    { 503, 3, 13, 37 },
                    { 504, 3, 14, 37 },
                    { 505, 3, 15, 37 },
                    { 506, 4, 1, 38 },
                    { 507, 4, 2, 38 },
                    { 508, 4, 3, 38 },
                    { 509, 4, 4, 38 },
                    { 510, 4, 5, 38 },
                    { 511, 4, 6, 38 },
                    { 512, 4, 7, 38 },
                    { 513, 4, 8, 38 },
                    { 514, 4, 9, 38 },
                    { 515, 4, 10, 38 },
                    { 516, 4, 11, 38 },
                    { 517, 4, 12, 38 },
                    { 518, 4, 13, 38 },
                    { 519, 4, 14, 38 },
                    { 520, 4, 15, 38 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TheaterRowId",
                table: "Seats",
                column: "TheaterRowId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_MovieId",
                table: "Shows",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_TheaterId",
                table: "Shows",
                column: "TheaterId");

            migrationBuilder.CreateIndex(
                name: "IX_TheaterRows_TheaterId",
                table: "TheaterRows",
                column: "TheaterId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_OrderId",
                table: "Tickets",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ShowId",
                table: "Tickets",
                column: "ShowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "TheaterRows");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Theaters");
        }
    }
}
