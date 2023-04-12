using BooksForLess.API.Models;
using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;
using Microsoft.AspNetCore.Mvc;

namespace BooksForLess.API.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoriesServiceQueries categoriesService;
        private readonly ICategoriesServiceCommands categoriesServiceCommands;

        public CategoryController(ICategoriesServiceQueries categoriesService, ICategoriesServiceCommands categoriesServiceCommands)
        {
            this.categoriesService = categoriesService;
            this.categoriesServiceCommands = categoriesServiceCommands;
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

        public async Task<IActionResult> CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                var categoryDTO = new CategoryRequestServiceDTO()
                {
                    Id = category.Id,
                    Name = category.Name,
                    DisplayOrder = category.DisplayOrder,
                };

                var response = await categoriesServiceCommands.AddCategory(categoryDTO);

            return RedirectToAction("GetAllCategories");
            }

            return View();
        }

        public async Task<IActionResult> EditCategory()
        {
            return View();
        }
    }
}
