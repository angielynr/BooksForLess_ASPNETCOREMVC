using BooksForLess.Repository.Interfaces;
using BooksForLess.Services.Interfaces;

namespace BooksForLess.Services.Commands
{
    public partial class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
    }
}
