using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using S21_AspNetCore_RazorSyntax.Models;

namespace S21_AspNetCore_RazorSyntax.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>();

        [HttpGet]
        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(w => w.Id == id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            products.Add(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(w => w.Id == id);
            return View(product);
        }
        
        [HttpPost]
        public IActionResult Edit(Product model)
        {
            var product = products.FirstOrDefault(w => w.Id == model.Id);
            product.Brand = model.Brand;
            product.Name = model.Name;
            product.Price = model.Price;
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(w => w.Id == id);
            products.Remove(product);
            return RedirectToAction("Index");
        }

        
    }
}
