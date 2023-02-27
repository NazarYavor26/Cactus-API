using Cactus_API.BLL.Models;
using Cactus_API.DAL.DbContexts;

namespace Cactus_API.BLL.Services
{
    public class ScooterProductService : IScooterProductService
    {
        public readonly AppDbContext _db;

        public ScooterProductService(AppDbContext db)
        {
            _db = db;
        }

        public List<ScooterProductModel> GetAllScoters()
        {
            List<ScooterProductModel> ScooterProductModel = new();
            foreach (var scooterProduct in _db.ScooterProducts.ToList())
            {
                ScooterProductModel.Add(new ScooterProductModel()
                {
                    Id = scooterProduct.Id,
                    Title = scooterProduct.Title,
                    Description = scooterProduct.Description,
                    Price = scooterProduct.Price,
                    IsAvailable = scooterProduct.IsAvailable,
                    Image = @"https://firebasestorage.googleapis.com/v0/b/cactus-bf101.appspot.com/o/ScooterProducts%2FScooterProduct" + scooterProduct.Id + ".webp?alt=media&token=d0456b09-a054-4667-8192-774646d3dfe8"
                });
            }

            return ScooterProductModel;
        }
    }
}
