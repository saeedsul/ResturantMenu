using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResturantMenu.Api.Data;
using ResturantMenu.Api.Interfaces;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Order>> Get()
        {
            return await _appDbContext.Orders.ToListAsync();
        }

        public async Task<Order> Get(int orderId)
        {
            return await _appDbContext.Orders.FirstOrDefaultAsync(c => c.OrderId == orderId);
        }

        public async Task<Order> Add(Order order)
        {
            var entity = await _appDbContext.Orders.AddAsync(order);

            await _appDbContext.SaveChangesAsync();

            return entity.Entity;
        }
    }
}