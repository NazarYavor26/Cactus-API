﻿using Cactus_API.BLL.Models;
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

        public List<ScooterProduct> GetAllScoters()
        {
         /*   _db.ScooterProducts.Add(new ScooterProduct() 
                {   
                    Title = "title1",
                    Description = "some desc 1",
                    Price = 1,
                    IsAvailable = true 
                });

            _db.SaveChanges();*/
            /*var list = new List<ScooterProductModel>() 
            var ScooterProducts = _db.ScooterProducts.ToList();*/
            /*   ScooterProductModel scooterProductModel = */
            return _db.ScooterProducts.ToList();
        }
    }
}
