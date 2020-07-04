using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using salessystem.Data.Models;

namespace salessystem.Data
{
    public class SalesDbContext : IdentityDbContext {
        public SalesDbContext() { }

        public SalesDbContext(DbContextOptions options) : base(options) { }
        
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
    }
}