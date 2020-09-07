using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
namespace AngularProj
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
        // Web API configuration and services
        https://localhost:44367/
            config.EnableCors(new EnableCorsAttribute("https://localhost:4200", methods: "*", headers: "*"));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
