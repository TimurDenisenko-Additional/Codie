using System.Web.Mvc;

namespace Codie.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Sissejuhatus()
        {
            return View();
        }
    }
}