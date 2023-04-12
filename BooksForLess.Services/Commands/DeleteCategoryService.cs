using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class CategoriesServiceCommands : ICategoriesServiceCommands
    {
        public async Task<AllCategoriesResponseDTO> DeleteCategory(int id)
        {
            var response = new AllCategoriesResponseDTO();

            var result = await this.categoriesRepositoryCommands.DeleteCategoryById(id);

            if (result == null)
            {
                return null;
            }

            response.ResultMessage = "Success!";

            return response;
        }
    }
}
