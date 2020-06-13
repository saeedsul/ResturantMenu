using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResturantMenu.Api.Data;
using ResturantMenu.Api.Interfaces;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Product>> Get()
        {
            var t = _appDbContext.Products.ToList();
            return await _appDbContext.Products.ToListAsync();
        }

        public async Task<Product> Get(int productId)
        {
            return await _appDbContext.Products.FirstOrDefaultAsync(c => c.ProductId == productId);
        }

        public async Task<Product> Add(Product product)
        {
            var entity = await _appDbContext.Products.AddAsync(product);

            await _appDbContext.SaveChangesAsync();

            return entity.Entity;
        }

        public async Task<Product> Update(Product product)
        {
            var entity = await _appDbContext.Products.FirstOrDefaultAsync(e => e.ProductId == product.ProductId);

            if (entity == null) return null;

            entity.UnitPrice = product.UnitPrice;
            entity.Name = product.Name;
            entity.TotalPrice = product.TotalPrice;
            entity.Image = product.Image;
            entity.IsAvailable = product.IsAvailable;
            entity.Quantity = product.Quantity;
            entity.CategoryId = product.CategoryId;

            await _appDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task Delete(int productId)
        {
            var entity = await _appDbContext.Products.FirstOrDefaultAsync(e => e.ProductId == productId);

            if (entity == null) return;

            _appDbContext.Products.Remove(entity);

            await _appDbContext.SaveChangesAsync();
        }
    }
}