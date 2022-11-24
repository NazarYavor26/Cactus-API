using Cactus_API.BLL.Models;

namespace Cactus_API.BLL.Services
{
    public interface IScooterProductService
    {
        List<ScooterProductModel> GetAllScoters();
        ScooterProductModel GetScoterById(int scooterId);
    }

}
