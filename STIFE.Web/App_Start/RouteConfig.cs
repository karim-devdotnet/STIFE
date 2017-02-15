﻿using System.Web.Mvc;
using System.Web.Routing;

namespace STIFE.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("DefaultLocalized",
            //"{language}-{culture}/{controller}/{action}/{id}",
            //new
            //{
            //    controller = "Home",
            //    action = "Index",
            //    id = "",
            //    language = "de",
            //    culture = "DE"
            //});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}