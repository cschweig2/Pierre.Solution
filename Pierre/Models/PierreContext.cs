using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pierre.Models
{
    public class PierreContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Treat> Treats { get; set; }
        public virtual DbSet<Flavor> Flavors { get; set; }
        public DbSet<FlavorTreat> FlavorTreat { get; set; }

        public PierreContext(DbContextOptions options) : base(options) { }
    }
}