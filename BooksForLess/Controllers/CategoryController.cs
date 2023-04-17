using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;
using BooksForLess.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksForLess.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public CategoryController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await categoriesService.GetAllCategories();

            List<Category> result = new List<Category>();

            foreach (var category in categories)
            {
                result.Add(new Category
                {
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

                var response = await categoriesService.AddCategory(categoryDTO);

                TempData["success"] = "Category created successfully";

                return RedirectToAction("GetAllCategories");
            }

            return View();
        }

        public async Task<IActionResult> EditCategory(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = await categoriesService.GetCategoriesById(id);

            var response = new Category()
            {
                Id = category.Id,
                Name = category.Name,
                DisplayOrder = category.DisplayOrder,
            };


            if (response == null)
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

                var response = await categoriesService.UpdateCategory(categoryDTO);

                TempData["success"] = "Category updated successfully";

                return RedirectToAction("GetAllCategories");
            }

            return View();
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = await categoriesService.GetCategoriesById(id);

            var response = new Category()
            {
                Id = category.Id,
                Name = category.Name,
                DisplayOrder = category.DisplayOrder,
            };


            if (response == null)
            {
                return NotFound(response);
            }

            return View(response);
        }

        [HttpPost, ActionName("DeleteCategory")]
        public async Task<IActionResult> DeleteCategoryPOST(int id)
        {
            if (ModelState.IsValid)
            {
                var response = await categoriesService.DeleteCategory(id);

                TempData["success"] = "Category deleted successfully";

                return RedirectToAction("GetAllCategories");
            }

            return View();
        }
    }
}
