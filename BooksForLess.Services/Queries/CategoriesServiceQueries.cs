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
        private readonly ICategoriesRepositoryQueries categoriesRepository;

        public CategoriesServiceQueries(ICategoriesRepositoryQueries categoriesRepository) {
            this.categoriesRepository = categoriesRepository;
        }
    }
}
