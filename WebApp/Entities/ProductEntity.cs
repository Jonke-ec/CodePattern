using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Entities
{
    public class ProductEntity
    {
        public ProductEntity()
        {
        }

        public ProductEntity(string title, string description, decimal price, ProductCategoryEntity name)
        {
            Title = title;
            Description = description;
            Price = price;
            Category = name;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = null!;

        [Required, Column(TypeName = "money")]
        public decimal Price { get; set; }

        public ProductCategoryEntity Category { get; set; } = null!;
        public int ProductCategoryEntityId { get; set; }
    }
}
