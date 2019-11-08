using System.Web;
using System.Web.Http;

namespace Stripped.Api {
    public class ApiApplication : HttpApplication {
        protected void Application_Start() => RouteConfig.RegisterRoutes(GlobalConfiguration.Configuration);
    }
}