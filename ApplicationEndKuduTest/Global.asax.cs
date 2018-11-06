using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ApplicationEndKuduTest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_End()
        {
            System.Diagnostics.Trace.TraceInformation("connectionStringValue="+ ConfigurationManager.ConnectionStrings["ApplicationEndKuduTest.Properties.Settings.MyConnectionString"]);
            System.Diagnostics.Trace.TraceInformation("settingValue=" + ConfigurationManager.AppSettings["MySetting"]);
            System.Diagnostics.Trace.Flush();
        }
    }
}
