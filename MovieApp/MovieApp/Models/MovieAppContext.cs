using Microsoft.EntityFrameworkCore;

namespace MovieApp.Models
{
    public class MovieAppContext : DbContext
    {
        public MovieAppContext(DbContextOptions<MovieAppContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(SeedData.Movies);

        }
    }
}
