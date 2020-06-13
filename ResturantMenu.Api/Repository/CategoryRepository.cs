using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResturantMenu.Api.Data;
using ResturantMenu.Api.Interfaces;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Category>> Get()
        {
            return await _appDbContext.Categories.ToListAsync();
        }

        public async Task<Category> Get(int categoryId)
        {
            return await _appDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == categoryId);
        }

        public async Task<Category> Add(Category category)
        {
            var entity = await _appDbContext.Categories.AddAsync(category);

            await _appDbContext.SaveChangesAsync();

            return entity.Entity;
        }

        public async Task<Category> Update(Category category)
        {
            var entity = await _appDbContext.Categories.FirstOrDefaultAsync(e => e.CategoryId == category.CategoryId);

            if (entity == null) return null;

            entity.Name = category.Name;
            entity.Sequence = category.Sequence;
            entity.Image = category.Image;
            entity.IsAvailable = category.IsAvailable;
            entity.Description = category.Description;

            await _appDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task Delete(int categoryId)
        {
            var entity = await _appDbContext.Categories.FirstOrDefaultAsync(e => e.CategoryId == categoryId);

            if (entity == null) return;

            _appDbContext.Categories.Remove(entity);

            await _appDbContext.SaveChangesAsync();
        }
    }
}