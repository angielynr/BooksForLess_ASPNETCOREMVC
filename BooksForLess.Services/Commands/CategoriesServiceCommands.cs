using BooksForLess.Repository.Interfaces;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public class CategoriesServiceCommands : ICategoriesServiceCommands
    {
        private readonly ICategoriesRepositoryCommands categoriesRepositoryCommands;

        public CategoriesServiceCommands(ICategoriesRepositoryCommands categoriesRepositoryCommands)
        {
            this.categoriesRepositoryCommands = categoriesRepositoryCommands;
        }
        public async Task<CategoriesResponse> AddCategory(CategoryServiceDTO category)
        {
            var response = new CategoriesResponse();

            var categories = await this.categoriesRepositoryCommands.AddCategory(new Repository.Entity.Categories()
            {
                Id= category.Id,
                Name= category.Name,
                DisplayOrder= category.DisplayOrder,
            });

            response.ResultMessage = "Success!";

            return response;
        }
    }
}
