using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Interfaces
{
    public interface ICategoriesRepositoryCommands
    {
        Task<CategoriesResponse> AddCategory(Categories categories);
    }
}
