using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class CategoriesServiceCommands : ICategoriesServiceCommands
    {

        public async Task<AllCategoriesResponseDTO> UpdateCategory(CategoryRequestServiceDTO category)
        {
            var response = new AllCategoriesResponseDTO();

            var updatedCategory = await this.categoriesRepositoryCommands.UpdateCategory(new Category()
            {
                Id= category.Id,
                Name= category.Name,
                DisplayOrder= category.DisplayOrder,
            });

            response = new AllCategoriesResponseDTO()
            {
                Id = category.Id,
                Name = category.Name,
                DisplayOrder = category.DisplayOrder,
            };

            return response;
        }
    }
}
