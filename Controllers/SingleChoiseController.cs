using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Codie.Models;
using Codie.Models.DB;
using Newtonsoft.Json;

namespace Codie.Controllers
{
    public class SingleChoiseController : Controller
    {
        private DBContext db = new DBContext();

        // GET: SingleChoise
        public ActionResult Index()
        {
            return View(db.SingleChoiseModels.ToList());
        }

        // GET: SingleChoise/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SingleChoiseModel singleChoiseModel = db.SingleChoiseModels.Find(id);
            if (singleChoiseModel == null)
            {
                return HttpNotFound();
            }
            return View(singleChoiseModel);
        }

        // GET: SingleChoise/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Statement,Options")] SingleChoiseModel singleChoiseModel)
        {
            if (ModelState.IsValid)
            {
                db.SingleChoiseModels.Add(singleChoiseModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(singleChoiseModel);
        }

        // GET: SingleChoise/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SingleChoiseModel singleChoiseModel = db.SingleChoiseModels.Find(id);
            if (singleChoiseModel == null)
            {
                return HttpNotFound();
            }
            return View(singleChoiseModel);
        }

        // POST: SingleChoise/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Statement,Options")] SingleChoiseModel singleChoiseModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(singleChoiseModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(singleChoiseModel);
        }

        // GET: SingleChoise/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SingleChoiseModel singleChoiseModel = db.SingleChoiseModels.Find(id);
            if (singleChoiseModel == null)
            {
                return HttpNotFound();
            }
            return View(singleChoiseModel);
        }

        // POST: SingleChoise/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SingleChoiseModel singleChoiseModel = db.SingleChoiseModels.Find(id);
            db.SingleChoiseModels.Remove(singleChoiseModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Tasks()
        {
            List<Tuple<string, SingleChoiseTask[]>> SCMList = new List<Tuple<string, SingleChoiseTask[]>>();
            foreach (SingleChoiseModel scm in db.SingleChoiseModels)
            {
                SCMList.Add(Tuple.Create(scm.Statement, JsonConvert.DeserializeObject<SingleChoiseTask[]>(scm.Options)));
            }
            return View(SCMList);
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
