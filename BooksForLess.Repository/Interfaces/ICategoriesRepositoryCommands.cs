using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Interfaces
{
    public interface ICategoriesRepositoryCommands
    {
        Task<CategoriesResponse> AddCategory(Category categories);

        Task<CategoriesResponse> UpdateCategory(Category categories);
        Task<CategoriesResponse> DeleteCategoryById(int id);

    }
}
