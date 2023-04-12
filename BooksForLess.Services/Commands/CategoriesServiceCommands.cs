using BooksForLess.Repository.Interfaces;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;


namespace BooksForLess.Services.Commands
{
    public partial class CategoriesServiceCommands : ICategoriesServiceCommands
    {
        private readonly ICategoriesRepositoryCommands categoriesRepositoryCommands;
        private readonly ICategoriesRepositoryQueries categoriesRepositoryQueries;

        public CategoriesServiceCommands(ICategoriesRepositoryCommands categoriesRepositoryCommands, ICategoriesRepositoryQueries categoriesRepositoryQueries)
        {
            this.categoriesRepositoryCommands = categoriesRepositoryCommands;
            this.categoriesRepositoryQueries = categoriesRepositoryQueries;
        }
    }
}
