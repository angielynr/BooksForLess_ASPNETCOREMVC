using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<Category>> GetAllCategories();
        Task<AllCategoriesResponse> GetCategoryById(int id);

        Task<CategoriesResponse> AddCategory(Category categories);

        Task<CategoriesResponse> UpdateCategory(Category categories);
        Task<CategoriesResponse> DeleteCategoryById(int id);

    }
}
