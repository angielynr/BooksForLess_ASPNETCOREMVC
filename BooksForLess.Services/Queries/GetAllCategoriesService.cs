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
        public async Task<List<AllCategoriesResponseDTO>> GetAllCategories()
        {
            var categories = await categoriesRepository.GetAllCategories();
            List<AllCategoriesResponseDTO> result = new List<AllCategoriesResponseDTO>();
            
            if(categories == null)
            {
                return null;
            }

            foreach (var category in categories)
            {
                result.Add(new AllCategoriesResponseDTO()
                {
                    Id= category.Id,
                    Name= category.Name,
                    DisplayOrder= category.DisplayOrder,
                });
            }

            return result;
        }
    }
}
