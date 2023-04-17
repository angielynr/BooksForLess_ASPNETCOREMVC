using BooksForLess.Services.Interfaces;
using BooksForLess.Services.ServiceDTO;
using BooksForLess.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksForLess.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetAllProducts();

            List<Product> result = new List<Product>();

            foreach (var product in products)
            {
                result.Add(new Product
                {
                    Id = product.Id,
                    Author = product.Author,
                    Description = product.Description,
                    ISBN = product.ISBN,
                    Price = product.Price,
                    ListPrice = product.ListPrice,
                    Price100 = product.Price100,
                    Price50 = product.Price50,
                });
            }
            return View(result);
        }

        public async Task<IActionResult> CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var productCategoryDTO = new ProductRequestServiceDTO()
                {
                    Id = product.Id,
                    Author = product.Author,
                    Description = product.Description,
                    ISBN = product.ISBN,
                    ListPrice = product.ListPrice,
                };

                var response = await productService.AddProduct(productCategoryDTO);

                TempData["success"] = "Product created successfully";

                return RedirectToAction("GetAllProducts");
            }

            return View();
        }

        public async Task<IActionResult> EditProduct(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = await productService.GetProductById(id);

            var response = new Product()
            {
                Id = product.Id,
                Author = product.Author,
                Description = product.Description,
                ISBN = product.ISBN,
                ListPrice = product.ListPrice,
            };


            if (response == null)
            {
                return NotFound(response);
            }

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var productDTO = new ProductRequestServiceDTO()
                {
                    Id = product.Id,
                    Author = product.Author,
                    Description = product.Description,
                    ISBN = product.ISBN,
                    ListPrice = product.ListPrice,
                };

                var response = await productService.UpdateProduct(productDTO);

                TempData["success"] = "Product updated successfully";

                return RedirectToAction("GetAllProducts");
            }

            return View();
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = await productService.GetProductById(id);

            var response = new Product()
            {
                Id = product.Id,
                Author = product.Author,
                Description = product.Description,
                ISBN = product.ISBN,
                ListPrice = product.ListPrice,
            };


            if (response == null)
            {
                return NotFound(response);
            }

            return View(response);
        }

        [HttpPost, ActionName("DeleteProduct")]
        public async Task<IActionResult> DeleteProductPOST(int id)
        {
            if (ModelState.IsValid)
            {
                var response = await productService.DeleteProduct(id);

                TempData["success"] = "Product deleted successfully";

                return RedirectToAction("GetAllProducts");
            }

            return View();
        }
    }
}
