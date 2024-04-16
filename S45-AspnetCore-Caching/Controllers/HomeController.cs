using Microsoft.AspNetCore.Mvc;
using S45_AspnetCore_Caching.Models;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace S45_AspnetCore_Caching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _memoryCache;
        private readonly IDistributedCache _distributedCache;

        public HomeController(ILogger<HomeController> logger,
        IMemoryCache memoryCache,
        IDistributedCache distributedCache)
        {
            _logger = logger;
            _memoryCache = memoryCache;
            _distributedCache = distributedCache;
        }

        public IActionResult Index()
        {
            //var lastUpdatedAt = GetLastUpdatedAtMemoryProxy();
            var lastUpdatedAt = GetLastUpdatedAtDisProxy();
            return View("Index", lastUpdatedAt.ToLongTimeString());
        }



        private DateTime GetLastUpdatedAtMemoryProxy()
        {
            //_memoryCache.Remove("lastUpdatedAt");

            var lastUpdatedAt = _memoryCache.Get<DateTime?>("lastUpdatedAt");
            if (lastUpdatedAt.HasValue == false)
            {
                lastUpdatedAt = GetLastUpdateFromSQLServer();
                _memoryCache.Set("lastUpdatedAt", lastUpdatedAt, new MemoryCacheEntryOptions()
                {
                    // حالت اول
                    // این کش بعد از 10 ثانیه در هر صورت حذف می شود
                    AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10)

                    // حالت دوم
                    // با هر بار فراخوانی 10 ثانیه کش تمدید می شود
                    //SlidingExpiration = TimeSpan.FromSeconds(10)

                    // حالت سوم
                    // استفاده ترکیبی ؟
                    // زمان انقضای این کش 300 ثانیه است
                    // ولی اگر تا 10 ثانیه کسی از این کش استفاده نکند کش به صورت خودکار
                    // حذف می شود
                    //AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(300),
                    //SlidingExpiration = TimeSpan.FromSeconds(10)
                });
            }
            return lastUpdatedAt.Value;
        }



        private DateTime GetLastUpdatedAtDisProxy()
        {
            //_distributedCache.Remove("lastUpdatedAt");

            DateTime output;
            var lastUpdatedAtBytes = _distributedCache.Get("lastUpdatedAt");

            if (lastUpdatedAtBytes is null)
            {
                output = GetLastUpdateFromSQLServer();
                var lastUpdatedAtSerialize = JsonSerializer.Serialize(output);
                 lastUpdatedAtBytes = Encoding.UTF8.GetBytes(lastUpdatedAtSerialize);

                _distributedCache.Set("lastUpdatedAt", lastUpdatedAtBytes, new DistributedCacheEntryOptions()
                {
                    // حالت اول
                    // این کش بعد از 10 ثانیه در هر صورت حذف می شود
                    AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10)

                    // حالت دوم
                    // با هر بار فراخوانی 10 ثانیه کش تمدید می شود
                    //SlidingExpiration = TimeSpan.FromSeconds(10)

                    // حالت سوم
                    // استفاده ترکیبی ؟
                    // زمان انقضای این کش 300 ثانیه است
                    // ولی اگر تا 10 ثانیه کسی از این کش استفاده نکند کش به صورت خودکار
                    // حذف می شود
                    //AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(300),
                    //SlidingExpiration = TimeSpan.FromSeconds(10)
                });
            }

            output = JsonSerializer.Deserialize<DateTime>(lastUpdatedAtBytes);
            return output;
        }

        private DateTime GetLastUpdateFromSQLServer()
        {
            return DateTime.Now;
        }
    }
}
