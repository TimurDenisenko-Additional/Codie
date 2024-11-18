using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Codie.Models;
using Codie.Models.DB;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Newtonsoft.Json;

namespace Codie.Controllers
{
    public class CodeTaskController : Controller
    {
        private DBContext db = new DBContext();

        // GET: CodeTask
        public ActionResult Index()
        {
            return View(DBContext.CodeTaskModels.ToList());
        }

        // GET: CodeTask/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeTaskModel codeTaskModel = DBContext.CodeTaskModels.Where(x => x.Id == id).ToList()[0];
            if (codeTaskModel == null)
            {
                return HttpNotFound();
            }
            return View(codeTaskModel);
        }
            
        // GET: CodeTask/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CodeTask/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Task,Code,Tests")] CodeTaskModel codeTaskModel)
        {
            if (ModelState.IsValid)
            {
                DBContext.CodeTaskModels.Add(codeTaskModel);
                return RedirectToAction("Index");
            }

            return View(codeTaskModel);
        }

        // GET: CodeTask/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeTaskModel codeTaskModel = DBContext.CodeTaskModels.Where(x => x.Id == id).ToList()[0];
            if (codeTaskModel == null)
            {
                return HttpNotFound();
            }
            return View(codeTaskModel);
        }

        // POST: CodeTask/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Task,Code,Tests")] CodeTaskModel codeTaskModel)
        {
            if (ModelState.IsValid)
            {
                DBContext.CodeTaskModels[DBContext.Accounts.Where(x => x.Id == codeTaskModel.Id).ToList()[0].Id] = codeTaskModel;
                return RedirectToAction("Index");
            }
            return View(codeTaskModel);
        }

        // GET: CodeTask/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeTaskModel codeTaskModel = DBContext.CodeTaskModels.Where(x => x.Id == id).ToList()[0];
            if (codeTaskModel == null)
            {
                return HttpNotFound();
            }
            return View(codeTaskModel);
        }

        // POST: CodeTask/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CodeTaskModel codeTaskModel = DBContext.CodeTaskModels.Where(x => x.Id == id).ToList()[0];
            DBContext.CodeTaskModels.Remove(codeTaskModel);
            return RedirectToAction("Index");
        }

        public ActionResult Tasks()
        {
            return View(DBContext.CodeTaskModels.ToList());
        }
        public async Task<JsonResult> TaskComplete(int id, string code)
        {
            Script script = CSharpScript.Create(code);
            string lines = "0";
            try
            {
                ScriptState result = await script.RunAsync();
                lines += "1";
                string codeResult = ("Edu! Kood koostatud. Tagastusväärtus: " + result?.ReturnValue ?? null);
                lines += "2";
                CodeTaskModel ctm = DBContext.CodeTaskModels.Where(x => x.Id == id).First();
                lines += string.Join(", ", ctm.Tests);
                (bool, string) testResult = await Test(script, ctm.Code, JsonConvert.DeserializeObject<string[]>(ctm.Tests));
                lines += "4";
                return Json(new { success = testResult.Item1, message = $"{codeResult}\n${testResult.Item2}" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Viga! {ex.Message} {lines}" });
            }
        }
        private async Task<(bool,string)> Test(Script testCode, string originalCode, params string[] tests)
        {
            Script workingScript = CSharpScript.Create(originalCode);
            Debug.WriteLine("0a");
            foreach (string test in tests)
            {
                ScriptState userResult = await testCode.ContinueWith(test).RunAsync();
                ScriptState expectedValue = await workingScript.ContinueWith(test).RunAsync();
                if (userResult.ReturnValue.ToString() != expectedValue.ReturnValue.ToString())
                {
                    return (false, "Ebaõnnestumine! Test: " + test + " | Eeldatav: " + expectedValue.ReturnValue + " | Tagastatud: " + userResult.ReturnValue);
                }
            }
            return (true, "Edu! Kõik testid läbisid edukalt");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
