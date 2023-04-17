using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace BooksForLess.Repository.Commands
{
    public partial class CategoriesRepository : ICategoriesRepository
    {
        public async Task<List<Category>> GetAllCategories()
        {
            return await appDbContext.categories.ToListAsync();
        }
    }
}
