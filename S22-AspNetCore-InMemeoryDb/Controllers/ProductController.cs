using Microsoft.AspNetCore.Mvc;
using S22_AspNetCore_InMemeoryDb.Models.Database;
using S22_AspNetCore_InMemeoryDb.Models.Entities;

namespace S22_AspNetCore_InMemeoryDb.Controllers
{
    public class ProductController : Controller
    {
        private InMemoryDatabase _database = new InMemoryDatabase();

        public ProductController()
        {
            // _database = new InMemoryDatabase();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_database.GetProducts());
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _database.FindProduct(id);
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
            _database.AddProduct(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _database.FindProduct(id);
            return View(product);
        }
        
        [HttpPost]
        public IActionResult Edit(Product model)
        {
            _database.EditProduct(model);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            _database.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        
    }
}
