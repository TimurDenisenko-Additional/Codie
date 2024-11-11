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
            {4, "OOP"},
            {5, "Memory"},
            {6, "ErrorHandling" },
            {7, "Array"},
            {8, "Lambda"},
            {9, "FileManage" },
            {10, "Async" },
            {11, "WindowsForms" },
            {12, "ADO" },
            {13, "ASP" },
            {14, "TDD" },
            {15, "Threads" }
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

        public ActionResult OOP()
        {
            pageOpened(4);
            return View();
        }

        public ActionResult Memory() 
        { 
            pageOpened(5);
            return View();
        }

        public ActionResult ErrorHandling()
        {
            pageOpened(6);
            return View();
        }

        public ActionResult Array()
        {
            pageOpened(7);
            return View();
        }

        public ActionResult Lambda()
        {
            pageOpened(8);
            return View();
        }

        public ActionResult FileManage()
        {
            pageOpened(9);
            return View();
        }

        public ActionResult Async()
        {
            pageOpened(10);
            return View();
        }

        public ActionResult WindowsForms()
        {
            pageOpened(11);
            return View();
        }

        public ActionResult ADO()
        {
            pageOpened(12);
            return View();
        }

        public ActionResult ASP()
        {
            pageOpened(13);
            return View();
        }

        public ActionResult TDD()
        {
            pageOpened(14);
            return View();
        }

        public ActionResult Threads()
        {
            pageOpened(15);
            return View();
        }
    }
}