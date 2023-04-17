using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace BooksForLess.Repository.Commands
{
    public partial class ProductRepository : IProductRepository
    {
        public async Task<List<Product>> GetAllProducts()
        {
            return await appDbContext.products.ToListAsync();
        }
    }
}
