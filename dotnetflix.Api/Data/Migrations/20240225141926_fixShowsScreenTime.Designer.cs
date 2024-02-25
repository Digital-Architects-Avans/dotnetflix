﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetflix.Api.Data;

#nullable disable

namespace dotnetflix.Api.Data.Migrations
{
    [DbContext(typeof(DotNetFlixDbContext))]
    [Migration("20240225141926_fixShowsScreenTime")]
    partial class fixShowsScreenTime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dotnetflix.Api.Data.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Runtime")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                            Image = "interstellar.jpg",
                            Rating = 2,
                            Runtime = 169,
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            Id = 2,
                            Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                            Image = "thedarkknight.jpg",
                            Rating = 3,
                            Runtime = 152,
                            Title = "The Dark Knight",
                            Year = 2008
                        },
                        new
                        {
                            Id = 3,
                            Description = "A thief who steals corporate secrets through dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                            Image = "inception.jpg",
                            Rating = 3,
                            Runtime = 148,
                            Title = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            Id = 4,
                            Description = "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                            Image = "parasite.jpg",
                            Rating = 4,
                            Runtime = 132,
                            Title = "Parasite",
                            Year = 2019
                        },
                        new
                        {
                            Id = 5,
                            Description = "After the devastating events of Avengers: Infinity War, the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                            Image = "avengersendgame.jpg",
                            Rating = 3,
                            Runtime = 181,
                            Title = "Avengers: Endgame",
                            Year = 2019
                        });
                });

            modelBuilder.Entity("dotnetflix.Api.Data.Entities.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ScreenTime")
                        .HasColumnType("int");

                    b.Property<int>("TheaterId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("TheaterId");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 12.00m,
                            Date = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenTime = 90,
                            TheaterId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 12.00m,
                            Date = new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenTime = 90,
                            TheaterId = 2,
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            BasePrice = 12.00m,
                            Date = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenTime = 90,
                            TheaterId = 3,
                            Type = 0
                        },
                        new
                        {
                            Id = 4,
                            BasePrice = 12.00m,
                            Date = new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenTime = 90,
                            TheaterId = 4,
                            Type = 0
                        },
                        new
                        {
                            Id = 5,
                            BasePrice = 12.00m,
                            Date = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenTime = 90,
                            TheaterId = 5,
                            Type = 0
                        },
                        new
                        {
                            Id = 6,
                            BasePrice = 12.00m,
                            Date = new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 1,
                            ScreenTime = 90,
                            TheaterId = 6,
                            Type = 0
                        },
                        new
                        {
                            Id = 7,
                            BasePrice = 14.00m,
                            Date = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenTime = 90,
                            TheaterId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 8,
                            BasePrice = 14.00m,
                            Date = new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenTime = 90,
                            TheaterId = 2,
                            Type = 0
                        },
                        new
                        {
                            Id = 9,
                            BasePrice = 14.00m,
                            Date = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenTime = 90,
                            TheaterId = 3,
                            Type = 0
                        },
                        new
                        {
                            Id = 10,
                            BasePrice = 14.00m,
                            Date = new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenTime = 90,
                            TheaterId = 4,
                            Type = 0
                        },
                        new
                        {
                            Id = 11,
                            BasePrice = 14.00m,
                            Date = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenTime = 90,
                            TheaterId = 5,
                            Type = 0
                        },
                        new
                        {
                            Id = 12,
                            BasePrice = 14.00m,
                            Date = new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 2,
                            ScreenTime = 90,
                            TheaterId = 6,
                            Type = 0
                        },
                        new
                        {
                            Id = 13,
                            BasePrice = 16.00m,
                            Date = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenTime = 90,
                            TheaterId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 14,
                            BasePrice = 16.00m,
                            Date = new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenTime = 90,
                            TheaterId = 2,
                            Type = 0
                        },
                        new
                        {
                            Id = 15,
                            BasePrice = 16.00m,
                            Date = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenTime = 90,
                            TheaterId = 3,
                            Type = 0
                        },
                        new
                        {
                            Id = 16,
                            BasePrice = 16.00m,
                            Date = new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenTime = 90,
                            TheaterId = 4,
                            Type = 0
                        },
                        new
                        {
                            Id = 17,
                            BasePrice = 16.00m,
                            Date = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenTime = 90,
                            TheaterId = 5,
                            Type = 0
                        },
                        new
                        {
                            Id = 18,
                            BasePrice = 16.00m,
                            Date = new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 3,
                            ScreenTime = 90,
                            TheaterId = 6,
                            Type = 0
                        },
                        new
                        {
                            Id = 19,
                            BasePrice = 18.00m,
                            Date = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenTime = 90,
                            TheaterId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 20,
                            BasePrice = 18.00m,
                            Date = new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenTime = 90,
                            TheaterId = 2,
                            Type = 0
                        },
                        new
                        {
                            Id = 21,
                            BasePrice = 18.00m,
                            Date = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenTime = 90,
                            TheaterId = 3,
                            Type = 0
                        },
                        new
                        {
                            Id = 22,
                            BasePrice = 18.00m,
                            Date = new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenTime = 90,
                            TheaterId = 4,
                            Type = 0
                        },
                        new
                        {
                            Id = 23,
                            BasePrice = 18.00m,
                            Date = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenTime = 90,
                            TheaterId = 5,
                            Type = 0
                        },
                        new
                        {
                            Id = 24,
                            BasePrice = 18.00m,
                            Date = new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 4,
                            ScreenTime = 90,
                            TheaterId = 6,
                            Type = 0
                        },
                        new
                        {
                            Id = 25,
                            BasePrice = 20.00m,
                            Date = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenTime = 90,
                            TheaterId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 26,
                            BasePrice = 20.00m,
                            Date = new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenTime = 90,
                            TheaterId = 2,
                            Type = 0
                        },
                        new
                        {
                            Id = 27,
                            BasePrice = 20.00m,
                            Date = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenTime = 90,
                            TheaterId = 3,
                            Type = 0
                        },
                        new
                        {
                            Id = 28,
                            BasePrice = 20.00m,
                            Date = new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenTime = 90,
                            TheaterId = 4,
                            Type = 0
                        },
                        new
                        {
                            Id = 29,
                            BasePrice = 20.00m,
                            Date = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenTime = 90,
                            TheaterId = 5,
                            Type = 0
                        },
                        new
                        {
                            Id = 30,
                            BasePrice = 20.00m,
                            Date = new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            MovieId = 5,
                            ScreenTime = 90,
                            TheaterId = 6,
                            Type = 0
                        });
                });

            modelBuilder.Entity("dotnetflix.Api.Data.Entities.Theater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Theaters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Theater 1",
                            Seats = 120
                        },
                        new
                        {
                            Id = 2,
                            Name = "Theater 2",
                            Seats = 120
                        },
                        new
                        {
                            Id = 3,
                            Name = "Theater 3",
                            Seats = 120
                        },
                        new
                        {
                            Id = 4,
                            Name = "Theater 4",
                            Seats = 60
                        },
                        new
                        {
                            Id = 5,
                            Name = "Theater 5",
                            Seats = 50
                        },
                        new
                        {
                            Id = 6,
                            Name = "Theater 6",
                            Seats = 50
                        });
                });

            modelBuilder.Entity("dotnetflix.Api.Data.Entities.Show", b =>
                {
                    b.HasOne("dotnetflix.Api.Data.Entities.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnetflix.Api.Data.Entities.Theater", "Theater")
                        .WithMany()
                        .HasForeignKey("TheaterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Theater");
                });
#pragma warning restore 612, 618
        }
    }
}
