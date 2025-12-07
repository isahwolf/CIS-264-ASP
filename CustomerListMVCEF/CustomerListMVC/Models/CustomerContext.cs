using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CustomerListMVC.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
    : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
