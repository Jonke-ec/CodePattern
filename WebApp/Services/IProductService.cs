using WebApp.Entities;

namespace WebApp.Services
{
    // 
    public interface IProductService
    {
        Task<IEnumerable<ProductEntity>> GetAllAsync();
    }
}
