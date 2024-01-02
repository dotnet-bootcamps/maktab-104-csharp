using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using S21_AspNetCore_RazorSyntax.Models;

namespace S21_AspNetCore_RazorSyntax.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Brand = "Microsoft",
                Name = "Surface",
                Price = 1000
            },
            new Product
            {
                Id = 2,
                Brand = "Dell",
                Name = "XPS",
                Price = 1000
            },
            new Product
            {
                Id = 3,
                Brand = "HP",
                Name = "ZBOOK",
                Price = 1000
            }
        };

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
    }
}
