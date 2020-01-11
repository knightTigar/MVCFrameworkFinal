using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFramework
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //order of the routs matters 

            routes.MapMvcAttributeRoutes();

            /*// we create custom route
            routes.MapRoute(
                "MovieByReleaseDate",
                "movies/released/{year}/{month}",
                new { Controller = "Movies" , action = "ByReleaseDate"},
                new { year = @"\d{4}", month = @"\d{2}"});// @ sign is bcoz of \
*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
