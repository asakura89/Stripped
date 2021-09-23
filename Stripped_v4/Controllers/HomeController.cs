using System.Web.Mvc;

namespace Stripped.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public ActionResult Index() => View();
    }
}