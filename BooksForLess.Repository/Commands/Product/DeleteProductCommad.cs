using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace BooksForLess.Repository.Commands
{
    public partial class ProductRepository : IProductRepository
    {
        public async Task<CustomResponse> DeleteProductById(int id)
        {
            var response = new CustomResponse();

            var result = await this.appDbContext.products.FirstOrDefaultAsync(c => c.Id == id);

            if (result == null)
            {
                return null;
            }

            response.ResultMessage = "Sucess!";

            appDbContext.Remove(result);
            await SaveChangesAsync();

            return response;
        }
    }
}
