namespace Cactus_API.BLL.Models
{
    public class ScooterProductModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string Image { get; set; }

        public bool IsAvailable { get; set; }
    }
}
