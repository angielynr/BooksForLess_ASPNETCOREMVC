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
        public Task<CategoriesResponse> DeleteCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
