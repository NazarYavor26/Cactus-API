using Cactus_API.BLL.Models;
using Cactus_API.DAL.DbContexts;
using Cactus_API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus_API.BLL.Services
{
    public class HelpCallService : IHelpCallService
    {
        public readonly AppDbContext _db;

        public HelpCallService(AppDbContext db)
        {
            _db = db;
        }

        public HelpCallModel AddHelpCallData(HelpCallModel helpCallModel)
        {
            if (helpCallModel != null)
            {
                _db.HelpCalls.Add(new HelpCall()
                { 
                    Name = helpCallModel.Name,
                    PhoneNumber = helpCallModel.PhoneNumber 
                });

                _db.SaveChanges();

                return helpCallModel;
            }

            return null;
        }
    }
}
