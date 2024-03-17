using dotnetflix.Api.Data.Entities;
using dotnetflix.Api.Entities;
using dotnetflix.Models.Dtos.Movie;
using dotnetflix.Models.Dtos.Show;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Data
{
    public class DotNetFlixDbContext : DbContext
    {
        public DotNetFlixDbContext(DbContextOptions<DotNetFlixDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Composite primary key for junction table
            modelBuilder.Entity<TicketSupplement>()
                .HasKey(ts => new { ts.TicketId, ts.SupplementId });

            // Set the precision and scale for the TotalPrice and BasePrice properties
            modelBuilder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .HasPrecision(6, 2);

            modelBuilder.Entity<Ticket>()
                .Property(t => t.TicketPrice)
                .HasPrecision(6, 2);

            modelBuilder.Entity<TicketType>()
                .Property(t => t.Discount)
                .HasPrecision(6, 2);
            
            modelBuilder.Entity<Supplement>()
                .Property(s => s.Price)
                .HasPrecision(6, 2);
            
            modelBuilder.Entity<Show>()
                .Property(s => s.BasePrice)
                .HasPrecision(6, 2); 

            // Seed data for Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1, Title = "Interstellar", Year = 2014,
                    Description =
                        "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    Rating = Rating.PG, Runtime = 169, SpokenLanguages = "EN", Image = "interstellar.jpg"
                },
                new Movie
                {
                    Id = 2, Title = "The Dark Knight", Year = 2008,
                    Description =
                        "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                    Rating = Rating.PG13, Runtime = 152, SpokenLanguages = "EN", Image = "thedarkknight.jpg"
                },
                new Movie
                {
                    Id = 3, Title = "Inception", Year = 2010,
                    Description =
                        "A thief who steals corporate secrets through dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                    Rating = Rating.PG13, Runtime = 148, SpokenLanguages = "EN", Image = "inception.jpg"
                },
                new Movie
                {
                    Id = 4, Title = "Parasite", Year = 2019,
                    Description =
                        "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                    Rating = Rating.R, Runtime = 132, SpokenLanguages = "EN", Image = "parasite.jpg"
                },
                new Movie
                {
                    Id = 5, Title = "Avengers: Endgame", Year = 2019,
                    Description =
                        "After the devastating events of Avengers: Infinity War, the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                    Rating = Rating.PG13, Runtime = 181, SpokenLanguages = "EN", Image = "avengersendgame.jpg"
                }
            );

            // Seed data for Theater
            modelBuilder.Entity<Theater>().HasData(
                new Theater { Id = 1, Name = "Theater 1", Seats = 120 },
                new Theater { Id = 2, Name = "Theater 2", Seats = 120 },
                new Theater { Id = 3, Name = "Theater 3", Seats = 120 },
                new Theater { Id = 4, Name = "Theater 4", Seats = 60 },
                new Theater { Id = 5, Name = "Theater 5", Seats = 50 },
                new Theater { Id = 6, Name = "Theater 6", Seats = 50 }
            );

            // Seed data for TheaterRow
            modelBuilder.Entity<TheaterRow>().HasData(
                // Theater 1
                new TheaterRow { Id = 1, TheaterId = 1, RowNumber = 1, NumberOfSeats = 15 },
                new TheaterRow { Id = 2, TheaterId = 1, RowNumber = 2, NumberOfSeats = 15 },
                new TheaterRow { Id = 3, TheaterId = 1, RowNumber = 3, NumberOfSeats = 15 },
                new TheaterRow { Id = 4, TheaterId = 1, RowNumber = 4, NumberOfSeats = 15 },
                new TheaterRow { Id = 5, TheaterId = 1, RowNumber = 5, NumberOfSeats = 15 },
                new TheaterRow { Id = 6, TheaterId = 1, RowNumber = 6, NumberOfSeats = 15 },
                new TheaterRow { Id = 7, TheaterId = 1, RowNumber = 7, NumberOfSeats = 15 },
                new TheaterRow { Id = 8, TheaterId = 1, RowNumber = 8, NumberOfSeats = 15 },

                // Theater 2
                new TheaterRow { Id = 9, TheaterId = 2, RowNumber = 1, NumberOfSeats = 15 },
                new TheaterRow { Id = 10, TheaterId = 2, RowNumber = 2, NumberOfSeats = 15 },
                new TheaterRow { Id = 11, TheaterId = 2, RowNumber = 3, NumberOfSeats = 15 },
                new TheaterRow { Id = 12, TheaterId = 2, RowNumber = 4, NumberOfSeats = 15 },
                new TheaterRow { Id = 13, TheaterId = 2, RowNumber = 5, NumberOfSeats = 15 },
                new TheaterRow { Id = 14, TheaterId = 2, RowNumber = 6, NumberOfSeats = 15 },
                new TheaterRow { Id = 15, TheaterId = 2, RowNumber = 7, NumberOfSeats = 15 },
                new TheaterRow { Id = 16, TheaterId = 2, RowNumber = 8, NumberOfSeats = 15 },

                // Theater 3
                new TheaterRow { Id = 17, TheaterId = 3, RowNumber = 1, NumberOfSeats = 15 },
                new TheaterRow { Id = 18, TheaterId = 3, RowNumber = 2, NumberOfSeats = 15 },
                new TheaterRow { Id = 19, TheaterId = 3, RowNumber = 3, NumberOfSeats = 15 },
                new TheaterRow { Id = 20, TheaterId = 3, RowNumber = 4, NumberOfSeats = 15 },
                new TheaterRow { Id = 21, TheaterId = 3, RowNumber = 5, NumberOfSeats = 15 },
                new TheaterRow { Id = 22, TheaterId = 3, RowNumber = 6, NumberOfSeats = 15 },
                new TheaterRow { Id = 23, TheaterId = 3, RowNumber = 7, NumberOfSeats = 15 },
                new TheaterRow { Id = 24, TheaterId = 3, RowNumber = 8, NumberOfSeats = 15 },

                // Theater 4
                new TheaterRow { Id = 25, TheaterId = 4, RowNumber = 1, NumberOfSeats = 10 },
                new TheaterRow { Id = 26, TheaterId = 4, RowNumber = 2, NumberOfSeats = 10 },
                new TheaterRow { Id = 27, TheaterId = 4, RowNumber = 3, NumberOfSeats = 10 },
                new TheaterRow { Id = 28, TheaterId = 4, RowNumber = 4, NumberOfSeats = 10 },
                new TheaterRow { Id = 29, TheaterId = 4, RowNumber = 5, NumberOfSeats = 10 },
                new TheaterRow { Id = 30, TheaterId = 4, RowNumber = 6, NumberOfSeats = 10 },

                // Theater 5
                new TheaterRow { Id = 31, TheaterId = 5, RowNumber = 1, NumberOfSeats = 10 },
                new TheaterRow { Id = 32, TheaterId = 5, RowNumber = 2, NumberOfSeats = 10 },
                new TheaterRow { Id = 33, TheaterId = 5, RowNumber = 3, NumberOfSeats = 15 },
                new TheaterRow { Id = 34, TheaterId = 5, RowNumber = 4, NumberOfSeats = 15 },

                // Theater 6
                new TheaterRow { Id = 35, TheaterId = 6, RowNumber = 1, NumberOfSeats = 10 },
                new TheaterRow { Id = 36, TheaterId = 6, RowNumber = 2, NumberOfSeats = 10 },
                new TheaterRow { Id = 37, TheaterId = 6, RowNumber = 3, NumberOfSeats = 15 },
                new TheaterRow { Id = 38, TheaterId = 6, RowNumber = 4, NumberOfSeats = 15 }
            );

            // Initialize a list to hold Seat seed data
            var seats = new List<Seat>();
            int seatId = 1; // Starting ID for seats

            // Seed data for Seats
            // Use a list of tuples to hold the TheaterRowId and the number of seats in that row
            var theaterRows = new List<(int TheaterRowId, int RowNumber, int NumberOfSeats)>
            {
                // Theater 1 Rows
                (1, 1, 15), (2, 2, 15), (3, 3, 15), (4, 4, 15), (5, 5, 15), (6, 6, 15), (7, 7, 15), (8, 8, 15),
                // Theater 2 Rows
                (9, 1, 15), (10, 2, 15), (11, 3, 15), (12, 4, 15), (13, 5, 15), (14, 6, 15), (15, 7, 15), (16, 8, 15),
                // Theater 3 Rows
                (17, 1, 15), (18, 2, 15), (19, 3, 15), (20, 4, 15), (21, 5, 15), (22, 6, 15), (23, 7, 15), (24, 8, 15),
                // Theater 4 Rows
                (25, 1, 10), (26, 2, 10), (27, 3, 10), (28, 4, 10), (29, 5, 10), (30, 6, 10),
                // Theater 5 Rows
                (31, 1, 10), (32, 2, 10), (33, 3, 15), (34, 4, 15),
                // Theater 6 Rows
                (35, 1, 10), (36, 2, 10), (37, 3, 15), (38, 4, 15),
            };

            // Loop through the list of tuples to create the seats for each row
            foreach (var row in theaterRows)
            {
                for (int seatNumber = 1; seatNumber <= row.NumberOfSeats; seatNumber++)
                {
                    seats.Add(new Seat
                    {
                        Id = seatId++,
                        SeatNumber = seatNumber,
                        TheaterRowId = row.TheaterRowId
                    });
                }
            }

            modelBuilder.Entity<Seat>().HasData(seats);

            // Seed data for Show
            // Assuming a pattern for shows, adjust as necessary
            int showId = 1;
            for (int movieId = 1; movieId <= 5; movieId++)
            {
                for (int theaterId = 1; theaterId <= 6; theaterId++)
                {
                    modelBuilder.Entity<Show>().HasData(
                        new Show
                        {
                            Id = showId++,
                            MovieId = movieId,
                            TheaterId = theaterId,
                            Date = DateTime.Now.AddHours(3),
                            ScreenTime = 90,
                            Type = MovieType.Regular,
                            SneakPreview = false
                        }
                    );
                }
            }
            
            modelBuilder.Entity<TicketType>().HasData(

                new TicketType
                {
                    Id = 1,
                    Name = "Normal",
                    Discount = 0M
                },
                new TicketType
                {
                    Id = 2,
                    Name = "Child",
                    Discount = 1.50M
                },
                new TicketType
                {
                    Id = 3,
                    Name = "Student",
                    Discount = 1.50M
                },
                new TicketType
                {
                    Id = 4,
                    Name = "Senior",
                    Discount = 1.50M
                },
                new TicketType
                {
                    Id = 5,
                    Name = "Cinema Pass",
                    Discount = 1.50M
                }
            );
            
            modelBuilder.Entity<Supplement>().HasData(

                new Supplement()
                {
                    Id = 1,
                    Name = "Large popcorn",
                    Price = 3.00M
                },
                new Supplement()
                {
                    Id = 2,
                    Name = "Large M&Ms",
                    Price = 4.00M
                },
                new Supplement()
                {
                    Id = 3,
                    Name = "Large popcorn",
                    Price = 1.50M
                }
            );
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<TheaterRow> TheaterRows { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Supplement> Supplements { get; set; }
        public DbSet<TicketSupplement> TicketSupplements { get; set; }
    }
}