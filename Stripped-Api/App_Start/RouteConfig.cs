using System.Web.Http;

namespace Stripped {
    public class RouteConfig {
        public static void RegisterRoutes(HttpConfiguration config) {
            config.Routes.MapHttpRoute(
                name: "Root",
                routeTemplate: "",
                defaults: new { controller = "Home", action = "Get" }
            );

            config.Routes.MapHttpRoute(
                name: "RootApi",
                routeTemplate: "api/",
                defaults: new { controller = "Home", action = "Get" }
            );

            config.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { controller = "Home", action = "Get" }
            );
        }
    }
}