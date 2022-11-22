using System.ComponentModel.DataAnnotations;

namespace Cactus_API.DAL.Entities
{
    public class ScooterProduct
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public bool IsAvailable { get; set; }
    }
}
