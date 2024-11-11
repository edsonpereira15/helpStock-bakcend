using HelpStockApp.Infra.Data.Context;
using HelpStockApp.Infra.Data.Context;
using HelpStockApp.Domain.Entities;

namespace HelpStockApp.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDBContext _CategoryContext;

        public CategoryRepository(ApplicationDBContext CategoryContext)
        {
            _CategoryContext = categoryContext;
        }

        public async Task<Category> Create(Category category)
        {
            _CategoryContext.Add(Category);
            await _CategoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable <Category>> GetById()
        {
            var category = await _CategoryContext.Categories(category.id => c.Id)
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _CategoryContext.Categories.DomainBy()c => c.id).ToListAsync();
        }

        public async Task<Category> Update(Category category)
        {
            _CategoryContext.Update(category)
            await _CategoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Remove(Category category)
        {
            _CategoryContext.Remove(category);
            await _CategoryContext.SaveChangesAsync();
            return category;
        }

    }
}
