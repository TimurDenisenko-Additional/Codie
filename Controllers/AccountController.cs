using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Codie.Models;
using Codie.Models.DB;

namespace Codie.Controllers
{
    public class AccountController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Account
        public ActionResult Index()
        {
            return View(db.Accounts.ToList());
        }

        // GET: Account/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccountModel accountModel = db.Accounts.Find(id);
            if (accountModel == null)
            {
                return HttpNotFound();
            }
            return View(accountModel);
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
                db.Accounts.Add(accountModel);
                db.SaveChanges();
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
            AccountModel accountModel = db.Accounts.Find(id);
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
                db.Entry(accountModel).State = EntityState.Modified;
                db.SaveChanges();
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
            AccountModel accountModel = db.Accounts.Find(id);
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
            AccountModel accountModel = db.Accounts.Find(id);
            db.Accounts.Remove(accountModel);
            db.SaveChanges();
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
                if (db.Accounts.Where(x => x.Email != accountModel.Email).Count() == 0)
                {
                    accountModel.Role = "User";
                    UserState.CurrentUser = accountModel;
                    db.Accounts.Add(accountModel);
                    db.SaveChanges();
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
                AccountModel reAcc = db.Accounts.Where(x => x.Email == accountModel.Email).ToList()[0];
                if (reAcc.Password == accountModel.Password)
                {
                    HttpContext.Cache.Insert("Authorized", true, null, DateTime.Now.AddDays(1), System.Web.Caching.Cache.NoSlidingExpiration);
                    UserState.Authorized = true;
                    UserState.CurrentUser = reAcc;
                    return RedirectToAction("Index", "Home");
                }
            }
            catch { }
            return View(accountModel);
        }
        public ActionResult Logout()
        {
            UserState.Authorized = false;
            UserState.CurrentUser = null;
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Recovery()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Recovery([Bind(Include = "Email")] AccountModel accountModel)
        {
            AccountModel fullAcc = db.Accounts.Where(x => x.Email == accountModel.Email).ToArray()[0];
            //Email($"{fullAcc.Email}", "Parooli taastamine", $"Teie PIN-kood: {fullAcc.PinCode}");
            return RedirectToAction("Login", "Account");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
