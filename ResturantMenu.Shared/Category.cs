using System.ComponentModel.DataAnnotations;

namespace ResturantMenu.Shared
{
    public class Category
    {
        [Required]
        [Key]
        //[RegularExpression("([0-9]+)", ErrorMessage = "Please select category from list")]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Sequence { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}