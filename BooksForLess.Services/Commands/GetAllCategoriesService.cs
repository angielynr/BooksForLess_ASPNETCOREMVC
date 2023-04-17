using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;

namespace BooksForLess.Services.Commands
{
    public partial class CategoriesService : ICategoriesService
    {
        public async Task<List<AllCategoriesResponseDTO>> GetAllCategories()
        {
            var categories = await categoriesRepository.GetAllCategories();
            List<AllCategoriesResponseDTO> result = new List<AllCategoriesResponseDTO>();

            if (categories == null)
            {
                return null;
            }

            foreach (var category in categories)
            {
                result.Add(new AllCategoriesResponseDTO()
                {
                    Id = category.Id,
                    Name = category.Name,
                    DisplayOrder = category.DisplayOrder,
                });
            }

            return result;
        }
    }
}

