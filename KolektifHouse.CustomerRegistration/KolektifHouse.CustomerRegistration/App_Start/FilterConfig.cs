using System.Web;
using System.Web.Mvc;

namespace KolektifHouse.CustomerRegistration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
