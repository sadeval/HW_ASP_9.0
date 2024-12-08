using HW_ASP_9._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP_9._0.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
