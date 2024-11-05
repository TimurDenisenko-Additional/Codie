using System.Collections.Generic;
using System.Web.Mvc;

namespace Codie.Controllers
{
    public class BookController : Controller
    {
        public static string PreviosPage;
        public static string NextPage;
        private int CurrentNumPage;
        private readonly Dictionary<int, string> pages = new Dictionary<int, string>()
        {
            {0, "404"},
            {1, "Introduction"},
            {2, "BasicTypes"},
            {3, "Methods"},

        };
        private void pageOpened(int currentPage)
        {
            CurrentNumPage = currentPage;
            PreviosPage = pages[pages.ContainsKey(currentPage - 1) ? currentPage - 1 : 0];
            NextPage = pages[pages.ContainsKey(currentPage + 1) ? currentPage + 1 : 0];
        }
        public ActionResult Introduction()
        {
            pageOpened(1);
            return View();
        }

        public ActionResult BasicTypes()
        {
            pageOpened(2);
            return View();
        }

        public ActionResult Methods()
        {
            pageOpened(3);
            return View();
        }
    }
}