using BooksForLess.API.Models;
using BooksForLess.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BooksForLess.API.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoriesServiceQueries categoriesService;

        public CategoryController(ICategoriesServiceQueries categoriesService)
        {
            this.categoriesService = categoriesService;
        }
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await categoriesService.GetAllCategories();

            List<Category> result = new List<Category>();
            
            foreach (var category in categories)
            {
                result.Add(new Category { 
                    Id = category.Id,
                    Name = category.Name,
                    DisplayOrder = category.DisplayOrder,
                });
            }
            return View(result);
        }
    }
}
