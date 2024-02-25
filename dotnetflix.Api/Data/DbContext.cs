using dotnetflix.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Api.Data
{
    public class DotNetFlixDbContext : DbContext
    {
        public DotNetFlixDbContext(DbContextOptions<DotNetFlixDbContext> options)
            : base(options)
        {
        }
        
                protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        
            // Seed data for Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1, Title = "Interstellar", Year = 2014,
                    Description =
                        "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    Rating = Rating.PG, Runtime = 169, Image = "interstellar.jpg"
                },
                new Movie
                {
                    Id = 2, Title = "The Dark Knight", Year = 2008,
                    Description =
                        "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                    Rating = Rating.PG13, Runtime = 152, Image = "thedarkknight.jpg"
                },
                new Movie
                {
                    Id = 3, Title = "Inception", Year = 2010,
                    Description =
                        "A thief who steals corporate secrets through dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                    Rating = Rating.PG13, Runtime = 148, Image = "inception.jpg"
                },
                new Movie
                {
                    Id = 4, Title = "Parasite", Year = 2019,
                    Description =
                        "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
                    Rating = Rating.R, Runtime = 132, Image = "parasite.jpg"
                },
                new Movie
                {
                    Id = 5, Title = "Avengers: Endgame", Year = 2019,
                    Description =
                        "After the devastating events of Avengers: Infinity War, the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                    Rating = Rating.PG13, Runtime = 181, Image = "avengersendgame.jpg"
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
                            Date = DateTime.Today.AddDays(theaterId), // Just an example, adjust accordingly
                            Time = new TimeSpan(19, 0, 0), // 7 PM for simplicity, adjust as needed
                            Type = MovieType.Regular,
                            BasePrice = 10.00m + (2 * movieId) // Example pricing strategy
                        }
                    );
                }
            }
        }
        
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Theater> Theaters { get; set; }
    }
}