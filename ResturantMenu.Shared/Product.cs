using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantMenu.Shared
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public string Image { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}