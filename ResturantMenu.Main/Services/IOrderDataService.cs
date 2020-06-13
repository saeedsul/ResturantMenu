using System.Collections.Generic;
using System.Threading.Tasks;
using ResturantMenu.Shared;

namespace ResturantMenu.Main.Services
{
    public interface IOrderDataService
    {
        Task<List<Order>> Get();
        Task<Order> Get(int orderId);
        Task<Order> Add(Order order);
    }
}