using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Commands
{
    public partial class ProductRepository : IProductRepository
    {
        public async Task<CustomResponse> AddProduct(Product product)
        {
            var response = new CustomResponse();

            await this.appDbContext.AddAsync(product);
            await SaveChangesAsync();

            response.ResultMessage = "Success!";

            return response;
        }
    }
}
