using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;

namespace BooksForLess.Repository.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<Category>> GetAllCategories();
        Task<AllCategoriesResponse> GetCategoryById(int id);

        Task<CustomResponse> AddCategory(Category categories);

        Task<CustomResponse> UpdateCategory(Category categories);
        Task<CustomResponse> DeleteCategoryById(int id);

    }
}
