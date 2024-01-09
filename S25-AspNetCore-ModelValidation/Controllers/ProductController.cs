using Microsoft.AspNetCore.Mvc;
using S25_AspNetCore_ModelValidation.Models.Database;
using S25_AspNetCore_ModelValidation.Models.Entities;

namespace S25_AspNetCore_ModelValidation.Controllers
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
            ViewBag.TarikheEmrooz = DateTime.Now;

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
            if (ModelState.IsValid)
            {
                if (model.Brand != "maktab")
                {
                    ModelState.AddModelError("Brand", "نام برند اشتباه است");
                    return View(model);
                }

                _database.AddProduct(model);
                return RedirectToAction("Index");
            }
            return View(model);
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
