using WebApp.Entities;
using WebApp.Interfaces;

namespace WebApp.Factories
{
    public class ProductFactory : IProductFactory
    {
        public ProductEntity Product(ProductEntity productEntity)
        {
            return new ProductEntity()
            {
                Id = productEntity.Id,
                Title = productEntity.Title,
                Description = productEntity.Description,
                Price = productEntity.Price,
                Category = productEntity.Category
            };
        }

        public List<ProductEntity> ProductList()
        {
            return new List<ProductEntity>();
        }
    }
}
