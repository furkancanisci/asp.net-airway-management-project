using Microsoft.EntityFrameworkCore;
using WebApplication3.Models.DBEntities;

namespace WebApplication3.DAL
{
    public class AirportsDbContext : DbContext
    {
        public AirportsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Airports> Airports { get; set; }
    }
}
