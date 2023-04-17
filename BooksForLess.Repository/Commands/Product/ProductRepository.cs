using BooksForLess.Repository.DataContext;
using BooksForLess.Repository.Interfaces;

namespace BooksForLess.Repository.Commands
{
    public partial class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;

        public ProductRepository(AppDbContext appDbContext) => this.appDbContext = appDbContext;

        private async Task SaveChangesAsync()
        {
            await this.appDbContext.SaveChangesAsync();
        }
    }
}
