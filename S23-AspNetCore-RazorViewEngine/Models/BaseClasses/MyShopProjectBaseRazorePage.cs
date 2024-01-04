using Microsoft.AspNetCore.Mvc.Razor;

namespace S23_AspNetCore_RazorViewEngine.Models.BaseClasses
{
    public abstract class MyShopProjectBaseRazorePage<TModel> : RazorPage<TModel>
    {

        public bool IsAuthenticated
        {
            get
            {
                return true;
            }
        }

        public string ShamsiDate
        {
            get
            {
                return "1402-10-16";
            }
        }
    }
}
