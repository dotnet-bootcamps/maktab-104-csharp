using Microsoft.AspNetCore.Mvc;
using S40_AspNetCore_DI.Models;
using System.Diagnostics;
using S40_AspNetCore_DI.Domain;
using S40_AspNetCore_DI.Models.LifeTimeDemo;

namespace S40_AspNetCore_DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MessageCreator messageCreator;

        public HomeController(
            ILogger<HomeController> logger, 
            MessageCreator creator)
        {
            _logger = logger;
            messageCreator = creator;
        }

        public string GetWelcomeMessage(int id=1)
        {
            var message = "Hello Dear {StudentName}";
            var result = messageCreator.Create(id, message);
            return result;
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
