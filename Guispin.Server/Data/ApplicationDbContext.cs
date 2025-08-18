using Microsoft.EntityFrameworkCore;
using Guispin.Shared.Models;

namespace Guispin.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }

        // Example/Test table
        public DbSet<Player>? Players { get; set; } = null;
    }
}
