using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmployeeTagger.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ControllerAndId",
                url: "{controller}/{action}/{id}",
                defaults: null,
                constraints: new { id = @"^\d+$" } //all digits
            );
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}" 
           );
        }
    }
}