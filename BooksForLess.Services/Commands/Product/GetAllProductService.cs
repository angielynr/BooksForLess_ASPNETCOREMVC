using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;

namespace BooksForLess.Services.Commands
{
    public partial class ProductService : IProductService
    {
        public async Task<List<AllProductResponseDTO>> GetAllProducts()
        {
            var categories = await productRepository.GetAllProducts();
            List<AllProductResponseDTO> result = new List<AllProductResponseDTO>();

            if (categories == null)
            {
                return null;
            }

            foreach (var category in categories)
            {
                result.Add(new AllProductResponseDTO()
                {
                    Id = category.Id,
                    Title = category.Title,
                    Description = category.Description,
                    Author = category.Author,
                    ISBN = category.ISBN,
                    ListPrice = category.ListPrice,
                    Price = category.Price,
                    Price50 = category.Price50,
                    Price100 = category.Price100,
                });
            }

            return result;
        }
    }
}

