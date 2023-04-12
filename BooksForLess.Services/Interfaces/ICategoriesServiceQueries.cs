using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksForLess.Services.ServiceDTO;

namespace BooksForLess.Services.Interfaces
{
    public interface ICategoriesServiceQueries
    { 
        Task<List<AllCategoriesResponseDTO>> GetAllCategories();

        Task<AllCategoriesResponseDTO> GetCategoriesById(int id);
    }
}
