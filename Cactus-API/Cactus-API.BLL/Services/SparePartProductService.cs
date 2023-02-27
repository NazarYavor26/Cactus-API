using Cactus_API.BLL.Models;
using Cactus_API.DAL.DbContexts;

namespace Cactus_API.BLL.Services
{
    public class SparePartProductService : ISparePartProductService
    {
        public readonly AppDbContext _db;

        public SparePartProductService(AppDbContext db)
        {
            _db = db;
        }

        public List<SparePartProductModel> GetAllSpareParts()
        {
            List<SparePartProductModel> SparePartProductModel = new();
            foreach (var sparePartProduct in _db.SparePartProducts.ToList())
            {
                SparePartProductModel.Add(new SparePartProductModel()
                {
                    Id = sparePartProduct.Id,
                    Title = sparePartProduct.Title,
                    Price = sparePartProduct.Price,
                    DeviceModel = sparePartProduct.DeviceModel,
                    Category = sparePartProduct.Category.ToString(),
                    Image = @"https://firebasestorage.googleapis.com/v0/b/cactus-bf101.appspot.com/o/SparePartProduct%2FSparePartProduct" + sparePartProduct.Id + ".jpg?alt=media&token=539f6d83-026c-4678-a1a1-1be82de1176e"
                });
            }

            return SparePartProductModel;
        }
    }
}
