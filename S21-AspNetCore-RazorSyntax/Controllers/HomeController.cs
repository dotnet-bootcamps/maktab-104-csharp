using Microsoft.AspNetCore.Mvc;
using S21_AspNetCore_RazorSyntax.Models;
using System.Diagnostics;

namespace S21_AspNetCore_RazorSyntax.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id, string name)
        {
            //return "Salam Donya " + id;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
