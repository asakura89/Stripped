using System.Web;
using System.Web.Routing;

namespace Stripped {
    public class MvcApplication : HttpApplication {
        protected void Application_Start() => RouteConfig.RegisterRoutes(RouteTable.Routes);
    }
}