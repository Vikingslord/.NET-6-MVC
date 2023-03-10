using System.ComponentModel.DataAnnotations;

namespace BookStore.WebAppMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; //Adding defualt value
    }
}
