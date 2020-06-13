using System.Collections.Generic;
using System.Threading.Tasks;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<Order>> Get();
        Task<Order> Get(int orderId);
        Task<Order> Add(Order order);
    }
}