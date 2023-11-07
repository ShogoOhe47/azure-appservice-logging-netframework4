using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            System.Diagnostics.Trace.TraceInformation($"{className}#{methodName}: Logging page is called. records from from System.Diagnostics.Trace.TraceInformation() method.");
            System.Diagnostics.Trace.TraceError($"{className}#{methodName}: Logging page is called. records from from System.Diagnostics.Trace.TraceError() method.");
            Console.WriteLine($"{className}#{methodName}: Logging page is called. records from from Console.WriteLine() method.");
            return View();
        }

        public ActionResult Diagnostics()
        {
            return View();
        }
    }
}