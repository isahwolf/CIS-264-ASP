using Microsoft.EntityFrameworkCore;

namespace CustSurveyMVC.Models
{
    public class TechSupportContext : DbContext
    {
        TechSupportContext db;

        public TechSupportContext(DbContextOptions<TechSupportContext> options) : base(options) { }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(FakeCustomerRepository.Customers);
        }

    }
}
