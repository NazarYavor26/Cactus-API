using Cactus_API.DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cactus_API.BLL
{
    public class BLLModule
    {
        public static void Load(IServiceCollection service, IConfiguration configuration)
        {
            DALModule.Load(service, configuration);
        }
    }
}
