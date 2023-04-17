using BooksForLess.Services.ServiceDTO;

namespace BooksForLess.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task<List<AllCategoriesResponseDTO>> GetAllCategories();

        Task<AllCategoriesResponseDTO> GetCategoriesById(int id);
        Task<AllCategoriesResponseDTO> AddCategory(CategoryRequestServiceDTO category);
        Task<AllCategoriesResponseDTO> UpdateCategory(CategoryRequestServiceDTO category);
        Task<AllCategoriesResponseDTO> DeleteCategory(int id);
    }
}
