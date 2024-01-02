using Microsoft.AspNetCore.Mvc;

namespace S22_AspNetCore_InMemeoryDb.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
