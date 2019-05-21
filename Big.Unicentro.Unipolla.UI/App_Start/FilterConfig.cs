using System.Web;
using System.Web.Mvc;

namespace Big.Unicentro.Unipolla.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
