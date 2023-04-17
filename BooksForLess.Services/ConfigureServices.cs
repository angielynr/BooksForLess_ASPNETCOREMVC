using BooksForLess.Repository.Commands;
using BooksForLess.Repository.Interfaces;
using BooksForLess.Services.Commands;
using BooksForLess.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BooksForLess.Services
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoriesRepository, CategoriesRepository>();
            services.AddScoped<ICategoriesService, CategoriesService>();

            return services;
        }
    }
}
