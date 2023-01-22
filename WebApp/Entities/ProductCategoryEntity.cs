using System.ComponentModel.DataAnnotations;

namespace WebApp.Entities
{
    public class ProductCategoryEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<ProductEntity> Products { get; set; } = null!;

    }
}
