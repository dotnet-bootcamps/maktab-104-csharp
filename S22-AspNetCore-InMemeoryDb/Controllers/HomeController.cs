using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using S22_AspNetCore_InMemeoryDb.Models;
using S22_AspNetCore_InMemeoryDb.Models.ViewModel;

namespace S22_AspNetCore_InMemeoryDb.Controllers
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
