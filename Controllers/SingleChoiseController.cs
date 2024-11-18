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
            return View(DBContext.SingleChoiseModels.ToList());
        }

        // GET: SingleChoise/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SingleChoiseModel singleChoiseModel = DBContext.SingleChoiseModels.Where(x => x.Id == id).ToList()[0];
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
                DBContext.SingleChoiseModels.Add(singleChoiseModel);
                return RedirectToAction("Index");
        }

        // GET: SingleChoise/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SingleChoiseModel singleChoiseModel = DBContext.SingleChoiseModels.Where(x => x.Id == id).ToList()[0];
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
                DBContext.SingleChoiseModels[DBContext.Accounts.Where(x => x.Id == singleChoiseModel.Id).ToList()[0].Id] = singleChoiseModel;
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
            SingleChoiseModel singleChoiseModel = DBContext.SingleChoiseModels.Where(x => x.Id == id).ToList()[0];
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
            SingleChoiseModel singleChoiseModel = DBContext.SingleChoiseModels.Where(x => x.Id == id).ToList()[0];
            DBContext.SingleChoiseModels.Remove(singleChoiseModel);
            return RedirectToAction("Index");
        }

        public ActionResult Tasks()
        {
            List<Tuple<string, Task[]>> SCMList = new List<Tuple<string, Task[]>>();
            foreach (SingleChoiseModel scm in DBContext.SingleChoiseModels)
            {
                SCMList.Add(Tuple.Create(scm.Statement, JsonConvert.DeserializeObject<Task[]>(scm.Options)));
            }
            return View(SCMList);
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
