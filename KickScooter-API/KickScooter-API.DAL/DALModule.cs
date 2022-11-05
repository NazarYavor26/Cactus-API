using KickScooter_API.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KickScooter_API.DAL
{
    public class DALModule
    {
        public static void Load(IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(option =>
            option.UseSqlServer(configuration.GetConnectionString("DBConnection"))
            );
        }
    }
}
