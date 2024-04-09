using Microsoft.AspNetCore.Mvc;
using S42_AspnetCore_Logging.Models;
using System.Diagnostics;
using S42_AspnetCore_Logging.InfrastructureCode;

namespace S42_AspnetCore_Logging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly SiteSettings _siteSettings;

        public HomeController(ILogger<HomeController> logger, 
            IConfiguration configuration,
            SiteSettings siteSettings)
        {
            _logger = logger;
            _configuration = configuration;
            _siteSettings = siteSettings;

            logger.LogInformation("This is a log from {provider} in {bootcamp}", "seq", "maktab-104");

            logger.LogTrace("This is a trace log");
            logger.LogDebug("This is a debug log");
            logger.LogInformation("This is a info log");
            logger.LogWarning("This is a warning log");
            logger.LogError("This is an error log");
            logger.LogCritical("This is a critical log" + Configs.ApplicationName);
        }

        public IActionResult Index()
        {
            var a = _siteSettings.SeqSettings.Address;


            var appName = _configuration["AppName"];
            var logCategory = _configuration["Logging:LogLevel:Microsoft.AspNetCore"];

            var logSection = _configuration.GetSection("Logging").GetSection("LogLevel");
            
            var defaultXConnectionString1 = _configuration["ConnectionStrings:Default"];
            var defaultXConnectionString = _configuration.GetConnectionString("Default");
            return View("Index", appName);
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
