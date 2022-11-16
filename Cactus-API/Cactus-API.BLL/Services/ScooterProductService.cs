using Cactus_API.BLL.Models;
using Cactus_API.DAL.DbContexts;
using Cactus_API.DAL.Entities;

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
                    Image = @"C:\Users\nazar\Desktop\Cactus\Cactus-API\Cactus-API\Cactus-API\Cactus-API.DAL\Images\ScooterProduct" + scooterProduct.Id + ".*"
                });
            }

            return ScooterProductModel;
        }
    }
}
