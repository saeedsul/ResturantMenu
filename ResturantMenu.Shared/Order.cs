using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResturantMenu.Shared
{
    public class Order
    {
        [Required]
        [Key]
        public int OrderId { get; set; }
        public double Total { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}