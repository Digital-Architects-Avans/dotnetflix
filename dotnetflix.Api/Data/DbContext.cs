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
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Theater> Theaters { get; set; }
    }
}