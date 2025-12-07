using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace CustomerListMVC.Models
{
    public partial class HalloweenContext : DbContext
    {
        public HalloweenContext(DbContextOptions<HalloweenContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(CustomerList.Customers);
            modelBuilder.Entity<State>().HasData(StatesRepository.States);
        }
    }
}
