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
            return View(db.MultiChoiseModels.ToList());
        }

        // GET: MultiChoise/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultiChoiseModel multiChoiseModel = db.MultiChoiseModels.Find(id);
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
                db.MultiChoiseModels.Add(multiChoiseModel);
                db.SaveChanges();
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
            MultiChoiseModel multiChoiseModel = db.MultiChoiseModels.Find(id);
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
                db.Entry(multiChoiseModel).State = EntityState.Modified;
                db.SaveChanges();
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
            MultiChoiseModel multiChoiseModel = db.MultiChoiseModels.Find(id);
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
            MultiChoiseModel multiChoiseModel = db.MultiChoiseModels.Find(id);
            db.MultiChoiseModels.Remove(multiChoiseModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Tasks()
        {
            List<Tuple<string, Task[]>> MCMList = new List<Tuple<string, Task[]>>();
            foreach (MultiChoiseModel mcm in db.MultiChoiseModels)
            {
                MCMList.Add(Tuple.Create(mcm.Statement, JsonConvert.DeserializeObject<Task[]>(mcm.Options)));
            }
            return View(MCMList);
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
