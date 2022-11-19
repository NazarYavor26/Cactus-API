using Cactus_API.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus_API.BLL.Models
{
    public class SparePartProductModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public SparePartDeviceModel? DeviceModel { get; set; }

        public string Category { get; set; }

        public string Image { get; set; }
    }
}
