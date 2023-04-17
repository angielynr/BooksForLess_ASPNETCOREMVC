﻿using BooksForLess.Repository.Entity;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class ProductService : IProductService
    {

        public async Task<AllProductResponseDTO> UpdateProduct(ProductRequestServiceDTO product)
        {
            var updatedCategory = await this.productRepository.UpdateProduct(new Product()
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Author = product.Author,
                ISBN = product.ISBN,
                ListPrice = product.ListPrice,
            });

            var response = new AllProductResponseDTO()
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Author = product.Author,
                ISBN = product.ISBN,
                ListPrice = product.ListPrice,
            };

            return response;
        }
    }
}
