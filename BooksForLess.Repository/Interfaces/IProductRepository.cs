using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
        Task<AllProductsResponse> GetProductById(int id);

        Task<CustomResponse> AddProduct(Product product);

        Task<CustomResponse> UpdateProduct(Product product);
        Task<CustomResponse> DeleteProductById(int id);

    }
}
