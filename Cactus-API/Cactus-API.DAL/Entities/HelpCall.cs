using System.ComponentModel.DataAnnotations;

namespace Cactus_API.DAL.Entities
{
    public class HelpCall
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
}
