using Microsoft.EntityFrameworkCore;
using Zeniata.Models;

namespace Zeniata.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Worker> Workers { get; set; }
    }
}
