using AEproiect.Shared;

namespace AEproiect.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductByCategory(string categoryUrl);
        Task<Product> GetProduct(int id);
    }
}
