using Microsoft.EntityFrameworkCore;

namespace SportStore.Models
{
    public class SportStoreContext : DbContext
    {
        public SportStoreContext(DbContextOptions<SportStoreContext> options) :base(options) { }



        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(FakeProductRespository.Products);

        }


    }
}
