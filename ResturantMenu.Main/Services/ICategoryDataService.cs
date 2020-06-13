using System.Collections.Generic;
using System.Threading.Tasks;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Services
{
    public interface ICategoryDataService
    {
        Task<List<Category>> Get();
        Task<Category> Get(int categoryId);
        Task<Category> Add(Category category);
        Task Update(Category category);
        Task Delete(int categoryId);
    }
}
