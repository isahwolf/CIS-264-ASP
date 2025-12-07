using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace ContactListMVC.Models
{
    public class ContactListContext : DbContext
    {
        public ContactListContext(DbContextOptions<ContactListContext> options) : base(options) { }



        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(FakeCustomerRepository.Customers);

        }
    }
}
