using System.Collections.Generic;
using System.Threading.Tasks;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> Get();
        Task<Category> Get(int categoryId);
        Task<Category> Add(Category category);
        Task<Category> Update(Category category);
        Task Delete(int categoryId);
    }
}