using System.ComponentModel.DataAnnotations;

namespace ResturantMenu.Shared
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Sequence { get; set; }
        public bool IsAvaliable { get; set; } = true;
    }
}