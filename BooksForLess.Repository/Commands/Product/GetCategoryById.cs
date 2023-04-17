using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;


namespace BooksForLess.Repository.Commands
{
    public partial class ProductRepository : IProductRepository
    {
        public async Task<AllProductsResponse> GetProductById(int id)
        {
            var response = new AllProductsResponse();
            var result = await appDbContext.products.Where(c => c.Id == id).FirstOrDefaultAsync();

            response = new AllProductsResponse()
            {
                Title = result.Title,
                Author = result.Author,
                Description = result.Description,
                ISBN = result.ISBN,
                Price = result.Price,
                ListPrice = result.ListPrice,
                Price50 = result.Price50,
                Price100 = result.Price100,
            };

            return response;
        }
    }
}
