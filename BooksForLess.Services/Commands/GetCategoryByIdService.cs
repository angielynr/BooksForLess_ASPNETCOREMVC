using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class CategoriesService : ICategoriesService
    {
        public async Task<AllCategoriesResponseDTO> GetCategoriesById(int id)
        {
            var result = await this.categoriesRepository.GetCategoryById(id);


            if (result == null)
            {
                return null;
            }

            var response = new AllCategoriesResponseDTO()
            {
                Id = result.Id,
                Name = result.Name,
                DisplayOrder = result.DisplayOrder,
            };

            return response;
        }
    }
}

