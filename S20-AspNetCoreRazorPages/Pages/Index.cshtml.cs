using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace S20_AspNetCoreRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Fulllname { get; set; }

        public void OnGet()
        {
            Fulllname = "hasan hasani";
        }
    }
}
