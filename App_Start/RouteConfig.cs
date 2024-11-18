using Codie.Models;
using Codie.Models.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace Codie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            DBContext db = new DBContext();
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Details", id = UrlParameter.Optional }
            );
        }
    }
}
