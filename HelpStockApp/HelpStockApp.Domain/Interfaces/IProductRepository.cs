using HelpStockApp.Domain.Entities;

namespace HelpStockApp.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GeProducts();
        Task<Product> GetById(int id);
        Task<Product> Create(Category category);
        Task<Product> Update(Category category);
        Task<Product> Delete(int id);
    }
}
