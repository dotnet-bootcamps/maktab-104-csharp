using Microsoft.AspNetCore.Mvc;
using S45_AspnetCore_Caching.Models;
using System.Diagnostics;
using Microsoft.Extensions.Caching.Memory;

namespace S45_AspnetCore_Caching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _memoryCache;

        public HomeController(ILogger<HomeController> logger
        , IMemoryCache memoryCache)
        {
            _logger = logger;
            _memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            var lastUpdatedAt = GetLastUpdatedAtProxy();
            return View("Index", lastUpdatedAt.ToLongTimeString());
        }



        private DateTime GetLastUpdatedAtProxy()
        {
            var lastUpdatedAt = _memoryCache.Get<DateTime?>("lastUpdatedAt");
            if (lastUpdatedAt.HasValue == false)
            {
                lastUpdatedAt = GetLastUpdateFromSQLServer();
                _memoryCache.Set("lastUpdatedAt", lastUpdatedAt, new MemoryCacheEntryOptions()
                {
                    // این کش بعد از 10 ثانیه در هر صورت حذف می شود
                    //AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10)

                    // با هر بار فراخوانی 10 ثانیه کش تمدید می شود
                    //SlidingExpiration = TimeSpan.FromSeconds(10)

                    // استفاده ترکیبی ؟
                    // زمان انقضای این کش 300 ثانیه است
                    // ولی اگر تا 10 ثانیه کسی از این کش استفاده نکند کش به صورت خودکار
                    // حذف می شود
                    AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(300),
                    SlidingExpiration = TimeSpan.FromSeconds(10)
                });
            }
            return lastUpdatedAt.Value;
        }

        private DateTime GetLastUpdateFromSQLServer()
        {
            return DateTime.Now;
        }
    }
}
