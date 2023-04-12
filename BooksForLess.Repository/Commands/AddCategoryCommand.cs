using Azure;
using BooksForLess.Repository.DataContext;
using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace BooksForLess.Repository.Commands
{
    public partial class CategeriesRepositoryCommands : ICategoriesRepositoryCommands
    {
        public async Task<CategoriesResponse> AddCategory(Categories categories)
        {
            var categoriesList = await this.appDbContext.categories.ToListAsync();
            var response = new CategoriesResponse();

            await this.appDbContext.AddAsync(categories);
            await SaveChangesAsync();

            response.ResultMessage = "Success!";

            return response;
        }
    }
}
