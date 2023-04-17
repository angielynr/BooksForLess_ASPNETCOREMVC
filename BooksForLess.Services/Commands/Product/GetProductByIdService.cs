using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class ProductService : IProductService
    {
        public async Task<AllProductResponseDTO> GetProductById(int id)
        {
            var result = await this.productRepository.GetProductById(id);


            if (result == null)
            {
                return null;
            }

            var response = new AllProductResponseDTO()
            {
                Id = result.Id,
                Title = result.Title,
                Description = result.Description,
                Author = result.Author,
                ISBN = result.ISBN,
                ListPrice = result.ListPrice,
                Price = result.Price,
                Price50 = result.Price50,
                Price100 = result.Price100,
            };

            return response;
        }
    }
}

