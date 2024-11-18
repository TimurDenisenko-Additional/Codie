using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Codie.Models;
using Codie.Models.DB;

namespace Codie.Controllers
{
    public class AccountController : Controller
    {
        

        // GET: Account
        public ActionResult Index()
        {
            return View(DBContext.Accounts.ToList());
        }

        // GET: Account/Details
        public ActionResult Details()
        {
            if (UserState.CurrentUser == null)
            {
                return HttpNotFound();
            }
            return View(UserState.CurrentUser);
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Gender,Email,Password,Role")] AccountModel accountModel)
        {
            if (ModelState.IsValid)
            {
                DBContext.Accounts.Add(accountModel);
                return RedirectToAction("Index");
            }

            return View(accountModel);
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = DBContext.Accounts.Where(x => x.Id == id).ToList()[0];
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            return View(accountModel);
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Gender,Email,Password,Role")] AccountModel accountModel)
        {
            if (ModelState.IsValid)
            {
                DBContext.Accounts[DBContext.Accounts.Where(x => x.Id == accountModel.Id).ToList()[0].Id] = accountModel;
                return RedirectToAction("Index");
            }
            return View(accountModel);
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = DBContext.Accounts.Where(x => x.Id == id).ToList()[0];
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            return View(accountModel);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccountModel accountModel = DBContext.Accounts.Where(x => x.Id == id).ToList()[0];
            DBContext.Accounts.Remove(accountModel);
            return RedirectToAction("Index");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "Id,FirstName,LastName,Gender,Email,Password,Role")] AccountModel accountModel)
        {
            try
            {
                if (DBContext.Accounts.ToList().Where(x => x.Email == accountModel.Email).Count() == 0)
                {
                    accountModel.Role = "User";
                    UserState.CurrentUser = accountModel;
                    DBContext.Accounts.Add(accountModel);
                    return RedirectToAction("Login", "Account");
                }
            }
            catch (Exception) { }
            return View(accountModel);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Email, Password")] AccountModel accountModel)
        {
            try
            {
                AccountModel reAcc = DBContext.Accounts.Where(x => x.Email == accountModel.Email).ToList()[0];
                if (reAcc.Password == accountModel.Password)
                {
                    HttpContext.Cache.Insert("Authorized", true, null, DateTime.Now.AddDays(1), System.Web.Caching.Cache.NoSlidingExpiration);
                    UserState.Authorized = true;
                    UserState.CurrentUser = reAcc;
                    return RedirectToAction("Introduction", "Book");
                }
            }
            catch { }
            return View(accountModel);
        }
        public ActionResult Logout()
        {
            UserState.Authorized = false;
            UserState.CurrentUser = null;
            return RedirectToAction("Introduction", "Book");
        }
        public ActionResult Recovery()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Recovery([Bind(Include = "Email")] AccountModel accountModel)
        {
            AccountModel fullAcc = DBContext.Accounts.Where(x => x.Email == accountModel.Email).ToArray()[0];
            //Email($"{fullAcc.Email}", "Parooli taastamine", $"Teie PIN-kood: {fullAcc.PinCode}");
            return RedirectToAction("Login", "Account");
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
