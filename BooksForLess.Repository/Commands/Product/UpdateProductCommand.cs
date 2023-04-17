using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace BooksForLess.Repository.Commands
{
    public partial class ProductRepository : IProductRepository
    {
        public async Task<CustomResponse> UpdateProduct(Product product)
        {
            var response = new CustomResponse();
            var isIdExisting = await this.appDbContext.products.FirstOrDefaultAsync(c => c.Id == product.Id);

            if (isIdExisting == null)
            {
                return null;
            }

            isIdExisting.Title = product.Title;
            isIdExisting.Description = product.Description;
            isIdExisting.Author = product.Author;
            isIdExisting.ISBN = product.ISBN;
            isIdExisting.ListPrice = product.ListPrice;
            isIdExisting.Price = product.Price;
            isIdExisting.Price50 = product.Price50;
            isIdExisting.Price100 = product.Price100;

            response.ResultMessage = "Success!";

            await SaveChangesAsync();

            return response;
        }
    }
}
