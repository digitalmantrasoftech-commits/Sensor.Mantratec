using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Sensor.Mantratec
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
        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            HttpContext.Current.Response.AddHeader("URL-Origin", "*");
            string lowercaseUrl = HttpContext.Current.Request.Url.ToString().ToLower();

            //------------------------------------------------Time - Attendance

            //if (lowercaseUrl == "https://www.minopcloud.com/attendance")
            //{
            //    Response.Status = "301 Moved Permanently";
            //    Response.AddHeader("Location", lowercaseUrl.Replace(lowercaseUrl, "https://www.minopcloud.com/Time-Attendance"));
            //    Response.End();
            //}
            //else if (lowercaseUrl == "https://www.minopcloud.com/attendance-feature")
            //{
            //    Response.Status = "301 Moved Permanently";
            //    Response.AddHeader("Location", lowercaseUrl.Replace(lowercaseUrl, "https://www.minopcloud.com/Time-Attendance"));
            //    Response.End();
            //}

        }
    }
}
public class HyphenatedRouteHandler : MvcRouteHandler
{
    protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
    {
        requestContext.RouteData.Values["controller"] = requestContext.RouteData.Values["controller"].ToString().Replace("-", "");
        requestContext.RouteData.Values["action"] = requestContext.RouteData.Values["action"].ToString().Replace("-", "");
        return base.GetHttpHandler(requestContext);
    }
}