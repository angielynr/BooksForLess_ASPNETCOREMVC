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
        private readonly ICategoriesServiceQueries categoriesServiceQueries;

        public CategoryController(ICategoriesServiceQueries categoriesService, ICategoriesServiceCommands categoriesServiceCommands, ICategoriesServiceQueries categoriesServiceQueries)
        {
            this.categoriesService = categoriesService;
            this.categoriesServiceCommands = categoriesServiceCommands;
            this.categoriesServiceQueries = categoriesServiceQueries;
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

        public async Task<IActionResult> EditCategory(int id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }

            var category = await this.categoriesServiceQueries.GetCategoriesById(id);

            var response = new Category()
            {
                Id = category.Id,
                Name = category.Name,
                DisplayOrder =category.DisplayOrder,
            };
           

            if(response == null)
            {
                return NotFound(response);
            }

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> EditCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                var categoryDTO = new CategoryRequestServiceDTO()
                {
                    Id = category.Id,
                    Name = category.Name,
                    DisplayOrder = category.DisplayOrder,
                };

                var response = await categoriesServiceCommands.UpdateCategory(categoryDTO);

                return RedirectToAction("GetAllCategories");
            }

            return View();
        }
    }
}
