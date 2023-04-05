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
    public class CategoriesServiceQueries : ICategoriesServiceQueries
    {
        private readonly ICategoriesRepositoryQueries categoriesRepository;

        public CategoriesServiceQueries(ICategoriesRepositoryQueries categoriesRepository) {
            this.categoriesRepository = categoriesRepository;
        }
        public async Task<List<CategoriesResponseDTO>> GetAllCategories()
        {
            var categories = await categoriesRepository.GetAllCategories();
            List<CategoriesResponseDTO> result = new List<CategoriesResponseDTO>();
            
            if(categories == null)
            {
                return null;
            }

            foreach (var category in categories)
            {
                result.Add(new CategoriesResponseDTO()
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
