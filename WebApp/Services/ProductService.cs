using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Entities;
using WebApp.Interfaces;

namespace WebApp.Services
{
    // Service delen och factory delen kör Dependency Inversion princip
    public class ProductService : IProductService
    {
        private readonly SqlContext _sqlContext;
        private readonly IProductFactory _productFactory;

        public ProductService(SqlContext sqlContext, IProductFactory productFactory)
        {
            _sqlContext = sqlContext;
            _productFactory = productFactory;
        }

        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            List<ProductEntity> products = _productFactory.ProductList();
            foreach (var product in await _sqlContext.Products.Include(x => x.Category).ToListAsync())
            {
                products.Add(_productFactory.Product(product));
            }
            return products;
        }
    }
}
