using Microsoft.AspNetCore.Mvc;

namespace S23_AspNetCore_RazorViewEngine.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
