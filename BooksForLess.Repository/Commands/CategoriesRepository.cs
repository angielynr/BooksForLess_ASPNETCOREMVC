using BooksForLess.Repository.DataContext;
using BooksForLess.Repository.Interfaces;

namespace BooksForLess.Repository.Commands
{
    public partial class CategoriesRepository : ICategoriesRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoriesRepository(AppDbContext appDbContext) => this.appDbContext = appDbContext;

        private async Task SaveChangesAsync()
        {
            await this.appDbContext.SaveChangesAsync();
        }
    }
}
