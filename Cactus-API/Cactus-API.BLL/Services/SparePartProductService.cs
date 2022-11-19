using Cactus_API.BLL.Models;
using Cactus_API.DAL.DbContexts;
using Cactus_API.DAL.Entities;

namespace Cactus_API.BLL.Services
{
    public class SparePartProductService : ISparePartProductService
    {
        public readonly AppDbContext _db;

        public SparePartProductService(AppDbContext db)
        {
            _db = db;

            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Xiaomi Mi Electric Scooter 1S",
                Price = 7.13,
                DeviceModel = "Xiaomi Mi Electric Scooter 1S",
                Category = DAL.Enums.SparePartCategory.Fenders,
                IsAvailable = true
            });

            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Xiaomi Mi Electric Scooter 2 M365 - Inner Tube CST 9 x 2",
                Price = 6.73,
                DeviceModel = "Xiaomi Mi Electric Scooter 2 M365",
                Category = DAL.Enums.SparePartCategory.InnerTubes,
                IsAvailable = true
            });

            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Kugoo S1, S1 Pro, S2, S3 - Charger 42V / 2A",
                Price = 15.25,
                DeviceModel = "Kugoo S1, Kugoo S2, Kugoo S3, Kugoo S1 Pro",
                Category = DAL.Enums.SparePartCategory.Fenders,
                IsAvailable = false
            });

            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Kugoo G2 Pro - Brake Pads 20mm",
                Price = 9.68,
                DeviceModel = "Kugoo G2 Pro",
                Category = DAL.Enums.SparePartCategory.OtherSmallParts,
                IsAvailable = true
            });
            //5
            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Kugoo M4, M4 Pro - Dashboard with LCD + Accelerator",
                Price = 28.98,
                DeviceModel = "Kugoo M4, Kugoo M4 Pro",
                Category = DAL.Enums.SparePartCategory.Components,
                IsAvailable = true
            });

            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Kugoo M4, M4 Pro, G2 Pro - Inner Tube 10 x 2.5 (Crooked Valve)",
                Price = 8.84,
                DeviceModel = "Kugoo G2 Pro, Kugoo M4, Kugoo M4 Pro",
                Category = DAL.Enums.SparePartCategory.InnerTubes,
                IsAvailable = false
            });
            //7
            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Kugoo M4, M4 Pro - Offroad Tire 10 x 3 / 255 x 80",
                Price = 15.47,
                DeviceModel = "Kugoo M4, Kugoo M4 Pro",
                Category = DAL.Enums.SparePartCategory.Tires,
                IsAvailable = true
            });

            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Xiaomi Mi Electric Scooter 1S, 2 M365, Essential, Pro, Pro 2 - Charger 42V / 1.7A",
                Price = 43.98,
                DeviceModel = "Xiaomi Mi Electric Scooter 2 M365, Xiaomi Mi Electric Scooter Pro, Xiaomi Mi Electric Scooter Pro 2, Xiaomi Mi Electric Scooter Essential, Xiaomi Mi Electric Scooter 1S",
                Category = DAL.Enums.SparePartCategory.OtherSmallParts,
                IsAvailable = true
            });
            //9
            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Xiaomi Mi Electric Scooter 1S, 2 M365, Essential - Rear Wheel + Brake Disc Complete (Black)",
                Price = 28.31,
                Category = DAL.Enums.SparePartCategory.Wheels,
                IsAvailable = true
            });

            _db.SparePartProducts.Add(new SparePartProduct()
            {
                Title = "Xiaomi Mi Electric Scooter 1S, 2 M365, Essential, Pro, Pro 2 - Charger SLS-4202 42V / 2A",
                Price = 13.32,
                DeviceModel = "Xiaomi Mi Electric Scooter 2 M365, Xiaomi Mi Electric Scooter Pro, Xiaomi Mi Electric Scooter Pro 2, Xiaomi Mi Electric Scooter Essential, Xiaomi Mi Electric Scooter 1S",
                Category = DAL.Enums.SparePartCategory.OtherSmallParts,
                IsAvailable = false
            });
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
                    Category = sparePartProduct.Category,
                    Image = @" https://firebasestorage.googleapis.com/v0/b/cactus-bf101.appspot.com/o/SparePartProduct%2FSparePartProduct" + sparePartProduct.Id + ".jpg?alt=media&token=539f6d83-026c-4678-a1a1-1be82de1176e"
                });
            }

            return SparePartProductModel;
        }
    }
}
