using Azure;
using BooksForLess.Repository.DataContext;
using BooksForLess.Repository.Entity;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.RepositoryDTO;
using Microsoft.EntityFrameworkCore;

namespace BooksForLess.Repository.Commands
{
    public class CategeriesRepositoryCommands : ICategoriesRepositoryCommands
    {
        private readonly AppDbContext appDbContext;

        public CategeriesRepositoryCommands(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        async Task<CategoriesResponse> ICategoriesRepositoryCommands.AddCategory(Categories categories)
        {
            var categoriesList = await this.appDbContext.categories.ToListAsync();
            var response = new CategoriesResponse();

            await this.appDbContext.AddAsync(categories);
            await this.appDbContext.SaveChangesAsync();

            response.ResultMessage = "Success!";

            return response;
        }
    }
}
