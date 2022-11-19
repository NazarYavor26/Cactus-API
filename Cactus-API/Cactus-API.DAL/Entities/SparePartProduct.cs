using Cactus_API.DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cactus_API.DAL.Entities
{
    public class SparePartProduct
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public double Price { get; set; }

        public SparePartDeviceModel? DeviceModel { get; set; }

        [Required]
        public string Category { get; set; }


    }
}
