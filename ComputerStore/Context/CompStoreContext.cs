using ComputerStore.Entities;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace ComputerStore.Context
{
    public class CompStoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server = ASUS\SQLEXPRESS; Database = ComputerStoreDb; Trusted_Connection = True; TrustServerCertificate=True;");
        }


        public DbSet<Computers> Computers { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderComputer> OrderComputers { get; set; }


    }
}
