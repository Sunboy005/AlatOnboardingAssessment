using Microsoft.EntityFrameworkCore;
using AlatAssessment.Entity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AlatAssessment.Data
{
    public class ApplicationDbContext : IdentityDbContext<Customer>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}

        public DbSet<Customer> Customers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Local> Locals { get; set; }
    }
}
