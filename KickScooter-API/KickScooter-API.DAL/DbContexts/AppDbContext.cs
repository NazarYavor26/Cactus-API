using KickScooter_API.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace KickScooter_API.DAL.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<HelpCall> HelpCalls { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  
        { }
    }
}
