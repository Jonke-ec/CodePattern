using WebApp.Entities;

namespace WebApp.Interfaces
{
    public interface IProductFactory
    {
        ProductEntity Product(ProductEntity productEntity);
        List<ProductEntity> ProductList();
    }
}
