using BooksForLess.Repository.Entity;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class CategoriesService : ICategoriesService
    {
        public async Task<AllCategoriesResponseDTO> AddCategory(CategoryRequestServiceDTO category)
        {
            var categories = await this.categoriesRepository.AddCategory(new Category()
            {
                Id = category.Id,
                Name = category.Name,
                DisplayOrder = category.DisplayOrder,
            });

            var response = new AllCategoriesResponseDTO()
            {
                Id = category.Id,
                Name = category.Name,
                DisplayOrder = category.DisplayOrder,
                ResultMessage = "Success!"
            };

            return response;
        }
    }
}
