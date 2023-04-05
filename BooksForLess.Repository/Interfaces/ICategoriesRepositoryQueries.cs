using BooksForLess.Repository.Entity;
using BooksForLess.Repository.RepositoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksForLess.Repository.Interfaces
{
    public interface ICategoriesRepositoryQueries
    {
        Task<List<Categories>> GetAllCategories();
    }
}
