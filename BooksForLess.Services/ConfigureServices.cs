using BooksForLess.Repository.Interfaces;
using BooksForLess.Repository.Queries;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace BooksForLess.Services
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<ICategoriesRepositoryQueries, CategeriesRepositoryQueries>();
            services.AddScoped<ICategoriesServiceQueries, CategoriesServiceQueries>();

            return services;
        }
    }
}
