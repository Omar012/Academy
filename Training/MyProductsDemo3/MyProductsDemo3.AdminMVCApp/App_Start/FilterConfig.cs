using System.Web;
using System.Web.Mvc;

namespace MyProductsDemo3.AdminMVCApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
