using System.Collections.Generic;
using System.Threading.Tasks;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> Get();
        Task<Product> Get(int productId);
        Task<Product> Add(Product product);
        Task<Product> Update(Product product);
        Task Delete(int productId);
    }
}