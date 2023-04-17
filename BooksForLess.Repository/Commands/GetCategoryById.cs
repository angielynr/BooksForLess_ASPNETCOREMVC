using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;


namespace BooksForLess.Repository.Commands
{
    public partial class CategoriesRepository : ICategoriesRepository
    {
        public async Task<AllCategoriesResponse> GetCategoryById(int id)
        {
            var response = new AllCategoriesResponse();
            var result = await appDbContext.categories.Where(c => c.Id == id).FirstOrDefaultAsync();

            response = new AllCategoriesResponse()
            {
                Name = result.Name,
                DisplayOrder = result.DisplayOrder,
                ResultMessage = "Success!"
            };

            return response;
        }
    }
}
