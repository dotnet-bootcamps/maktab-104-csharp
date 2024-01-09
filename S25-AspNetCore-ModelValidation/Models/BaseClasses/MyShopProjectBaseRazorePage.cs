using Microsoft.AspNetCore.Mvc.Razor;

namespace S25_AspNetCore_ModelValidation.Models.BaseClasses
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
