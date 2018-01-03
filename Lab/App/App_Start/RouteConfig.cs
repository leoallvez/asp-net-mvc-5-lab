using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //URL - amigaveis
            routes.MapRoute(
                name: "Todas Noticias",
                url: "noticias/",
                defaults: new { controller = "Noticia", action = "TodasAsNoticias" }
            );

            routes.MapRoute(
               name: "Categoria",
               url: "noticias/{categoria}",
               defaults: new { controller = "Noticia", action = "MostraCategoria" }
            );

            routes.MapRoute(
               name: "Categoria e titulo",
               url: "noticias/{categoria}/{titulo}/{id}",
               defaults: new { controller = "Noticia", action = "MostraNoticia" }
            );

            // URL - Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
