using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rental.Data;

namespace Rental.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<Video> Video { get; set; }
    }
}
