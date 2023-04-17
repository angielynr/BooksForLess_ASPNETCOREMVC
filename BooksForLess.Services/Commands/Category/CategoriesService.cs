using BooksForLess.Repository.Interfaces;
using BooksForLess.Services.Interfaces;

namespace BooksForLess.Services.Commands
{
    public partial class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository categoriesRepository;

        public CategoriesService(ICategoriesRepository categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }
    }
}
