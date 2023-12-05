using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace azure_appservice_logging_netframework4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logging()
        {
            string className = GetType().Name;
            string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            if (System.Environment.GetEnvironmentVariable("WEBSITE_SITE_NAME").IsEmpty() == false)
            {
                // this code only running on Azure
                // System.Diagnostics.Trace.TraceInformation is logging to AppServiceLog:ApplicationLog
                System.Diagnostics.Trace.TraceInformation($"{className}#{methodName}: Logging page is called. records from from System.Diagnostics.Trace.TraceInformation() method.");
                // System.Diagnostics.Trace.TraceInformation is logging to AppServiceLog:ApplicationLog, DiagnosticsSettings:AppServiceAppLogs
                System.Diagnostics.Trace.TraceError($"{className}#{methodName}: Logging page is called. records from from System.Diagnostics.Trace.TraceError() method.");
            }
            Console.WriteLine($"{className}#{methodName}: Logging page is called. records from from Console.WriteLine() method.");
            return View();
        }

        public ActionResult Diagnostics()
        {
            return View();
        }
    }
}