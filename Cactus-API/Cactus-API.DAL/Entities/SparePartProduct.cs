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

        public string? DeviceModel { get; set; }

        [Required]
        public SparePartCategory Category { get; set; }

        [Required]
        public bool IsAvailable { get; set; }
    }
}
