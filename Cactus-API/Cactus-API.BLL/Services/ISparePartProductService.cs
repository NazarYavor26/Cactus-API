using Cactus_API.BLL.Models;

namespace Cactus_API.BLL.Services
{
    public interface ISparePartProductService
    {
        List<SparePartProductModel> GetAllSpareParts();
    }
}
