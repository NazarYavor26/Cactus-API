using Cactus_API.BLL.Models;
using Cactus_API.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus_API.BLL.Services
{
    public interface IScooterProductService
    {
        List<ScooterProduct> GetAllScoters();
    }
}
