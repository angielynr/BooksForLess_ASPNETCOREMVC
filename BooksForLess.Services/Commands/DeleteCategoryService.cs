using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class CategoriesService : ICategoriesService
    {
        public async Task<AllCategoriesResponseDTO> DeleteCategory(int id)
        {
            var response = new AllCategoriesResponseDTO();

            var result = await this.categoriesRepository.DeleteCategoryById(id);

            if (result == null)
            {
                return null;
            }

            response.ResultMessage = "Success!";

            return response;
        }
    }
}
