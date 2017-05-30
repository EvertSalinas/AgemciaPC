using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Agemcia
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "ProductForm",
                "Producto/Editar/{id}",
                defaults: new { controller = "Producto", action = "Editar", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Product",
                "Producto",
                defaults: new { controller = "Producto", action = "Lista", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
