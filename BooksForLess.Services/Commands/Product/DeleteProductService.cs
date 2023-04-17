using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class ProductService : IProductService
    {
        public async Task<AllProductResponseDTO> DeleteProduct(int id)
        {
            var response = new AllProductResponseDTO();

            var result = await this.productRepository.DeleteProductById(id);

            if (result == null)
            {
                return null;
            }

            response.ResultMessage = "Success!";

            return response;
        }
    }
}
