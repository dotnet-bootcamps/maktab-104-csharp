using Microsoft.AspNetCore.Mvc;
using S42_AspnetCore_Logging.Models;
using System.Diagnostics;

namespace S42_AspnetCore_Logging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            logger.LogTrace("This is a trace log");
            logger.LogDebug("This is a debug log");
            logger.LogInformation("This is a info log");
            logger.LogWarning("This is a warning log");
            logger.LogError("This is an error log");
            logger.LogCritical("This is a critical log");
        }

        public IActionResult Index()
        {
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
