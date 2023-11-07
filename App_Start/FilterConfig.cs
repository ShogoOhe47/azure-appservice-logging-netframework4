using System.Web;
using System.Web.Mvc;

namespace azure_appservice_logging_netframework4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
