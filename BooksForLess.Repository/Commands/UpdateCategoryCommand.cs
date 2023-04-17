using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace BooksForLess.Repository.Commands
{
    public partial class CategoriesRepository : ICategoriesRepository
    {
        public async Task<CategoriesResponse> UpdateCategory(Category categories)
        {
            var response = new CategoriesResponse();
            var isIdExisting = await this.appDbContext.categories.FirstOrDefaultAsync(c => c.Id == categories.Id);

            if (isIdExisting == null)
            {
                return null;
            }

            isIdExisting.Name = categories.Name;
            isIdExisting.DisplayOrder = categories.DisplayOrder;

            response.ResultMessage = "Success!";

            await SaveChangesAsync();

            return response;
        }
    }
}
