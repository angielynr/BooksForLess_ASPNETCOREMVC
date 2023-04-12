using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksForLess.Services.ServiceDTO;

namespace BooksForLess.Services.Interfaces
{
    public interface ICategoriesServiceCommands
    { 
        Task<AllCategoriesResponseDTO> AddCategory(CategoryRequestServiceDTO category);
    }
}
