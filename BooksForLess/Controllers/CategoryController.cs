using Microsoft.AspNetCore.Mvc;

namespace BooksForLess.API.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult GetAllCategories()
        {
            return View();
        }
    }
}
