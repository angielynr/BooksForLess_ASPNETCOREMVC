using BooksForLess.Services.ServiceDTO;

namespace BooksForLess.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<AllProductResponseDTO>> GetAllProducts();

        Task<AllProductResponseDTO> GetProductById(int id);
        Task<AllProductResponseDTO> AddProduct(ProductRequestServiceDTO productRequest);
        Task<AllProductResponseDTO> UpdateProduct(ProductRequestServiceDTO productRequest);
        Task<AllProductResponseDTO> DeleteProduct(int id);
    }
}
