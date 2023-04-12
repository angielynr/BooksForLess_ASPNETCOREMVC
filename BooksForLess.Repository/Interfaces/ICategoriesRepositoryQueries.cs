using BooksForLess.Repository.Entity;

namespace BooksForLess.Repository.Interfaces
{
    public interface ICategoriesRepositoryQueries
    {
        Task<List<Categories>> GetAllCategories();
    }
}
