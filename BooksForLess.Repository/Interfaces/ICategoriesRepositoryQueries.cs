using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Interfaces
{
    public interface ICategoriesRepositoryQueries
    {
        Task<List<Category>> GetAllCategories();

        Task<AllCategoriesResponse> GetCategoryById(int id);
    }
}
