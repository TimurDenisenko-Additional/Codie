using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Codie.Models;
using Codie.Models.DB;
using Newtonsoft.Json;

namespace Codie.Controllers
{
    public class MultiChoiseController : Controller
    {
        private DBContext db = new DBContext();

        // GET: MultiChoise
        public ActionResult Index()
        {
            return View(DBContext.MultiChoiseModels.ToList());
        }

        // GET: MultiChoise/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiChoiseModel multiChoiseModel = DBContext.MultiChoiseModels.Where(x => x.Id == id).ToList()[0];
            if (multiChoiseModel == null)
            {
                return HttpNotFound();
            }
            return View(multiChoiseModel);
        }

        // GET: MultiChoise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultiChoise/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Statement,Options")] MultiChoiseModel multiChoiseModel)
        {
            if (ModelState.IsValid)
            {
                DBContext.MultiChoiseModels.Add(multiChoiseModel);
                return RedirectToAction("Index");
            }

            return View(multiChoiseModel);
        }

        // GET: MultiChoise/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiChoiseModel multiChoiseModel = DBContext.MultiChoiseModels.Where(x => x.Id == id).ToList()[0];
            if (multiChoiseModel == null)
            {
                return HttpNotFound();
            }
            return View(multiChoiseModel);
        }

        // POST: MultiChoise/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Statement,Options")] MultiChoiseModel multiChoiseModel)
        {
            if (ModelState.IsValid)
            {
                DBContext.MultiChoiseModels[DBContext.Accounts.Where(x => x.Id == multiChoiseModel.Id).ToList()[0].Id] = multiChoiseModel;
                return RedirectToAction("Index");
            }
            return View(multiChoiseModel);
        }

        // GET: MultiChoise/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiChoiseModel multiChoiseModel = DBContext.MultiChoiseModels.Where(x => x.Id == id).ToList()[0];
            if (multiChoiseModel == null)
            {
                return HttpNotFound();
            }
            return View(multiChoiseModel);
        }

        // POST: MultiChoise/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MultiChoiseModel multiChoiseModel = DBContext.MultiChoiseModels.Where(x => x.Id == id).ToList()[0];
            DBContext.MultiChoiseModels.Remove(multiChoiseModel);
            return RedirectToAction("Index");
        }
        public ActionResult Tasks()
        {
            List<Tuple<string, Task[]>> MCMList = new List<Tuple<string, Task[]>>();
            foreach (MultiChoiseModel mcm in DBContext.MultiChoiseModels)
            {
                MCMList.Add(Tuple.Create(mcm.Statement, JsonConvert.DeserializeObject<Task[]>(mcm.Options)));
            }
            return View(MCMList);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
