namespace Cactus_API.BLL.Models
{
    public class SparePartProductModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }

        public string? DeviceModel { get; set; }

        public string Category { get; set; }

        public string Image { get; set; }
    }
}
