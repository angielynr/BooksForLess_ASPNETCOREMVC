using BooksForLess.Repository.Interfaces;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksForLess.Services.Queries
{
    public partial class CategoriesServiceQueries : ICategoriesServiceQueries
    {
        public async Task<AllCategoriesResponseDTO> GetCategoriesById(int id)
        {
            var result = await this.categoriesRepository.GetCategoryById(id);
            
            if(result == null)
            {
                return null;
            }

            var response = new AllCategoriesResponseDTO()
            {
                Id = result.Id,
                Name = result.Name,
                DisplayOrder = result.DisplayOrder,
            };

            return response;
        }
    }
}
