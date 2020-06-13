using System.Collections.Generic;
using System.Threading.Tasks;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Services
{
    public interface IProductDataService
    {
        Task<List<Product>> Get();
        Task<Product> Get(int productId);
        Task<ProductModel> Add(Product product);
        Task Update(Product product);
        Task Delete(int productId);
    }
}