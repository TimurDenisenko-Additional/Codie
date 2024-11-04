using System.Web.Mvc;

namespace Codie.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Introduction () => View();
        public ActionResult BasicTypes() => View();
        public ActionResult Methods() => View();
    }
}