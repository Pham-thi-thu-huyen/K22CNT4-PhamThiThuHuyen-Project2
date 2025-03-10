﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace K22CNT4_TTCD1_PhamThiThuHuyen
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
           

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[]{"K22CNT4_TTCD1_PhamThiThuHuyen.Controllers"}
                );
            routes.MapRoute(
                name: "ItemDetails",
                url: "Item/Details/{id}",
                defaults: new { controller = "Item", action = "Details", id = UrlParameter.Optional }
);

        }
    }
}
