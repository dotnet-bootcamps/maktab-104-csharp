using Microsoft.AspNetCore.Mvc;

namespace S20_AspNetCoreMVC.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
