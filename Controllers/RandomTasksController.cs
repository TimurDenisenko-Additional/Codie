using Codie.Models;
using Codie.Models.DB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codie.Controllers
{
    public class RandomTasksController : Controller
    {
        DBContext db = new DBContext();
        Random rndNum = new Random();
        public ActionResult EasyTest() 
        { 
            SingleChoiseModel scm = db.SingleChoiseModels.ToArray()[rndNum.Next(0, db.SingleChoiseModels.Count())];
            Tuple<string, Task[]> SingleTask = Tuple.Create(scm.Statement, JsonConvert.DeserializeObject<Task[]>(scm.Options));
            MultiChoiseModel mcm = db.MultiChoiseModels.ToArray()[rndNum.Next(0, db.MultiChoiseModels.Count())];
            Tuple<string, Task[]> MultiTask = Tuple.Create(mcm.Statement, JsonConvert.DeserializeObject<Task[]>(mcm.Options));
            CodeTaskModel ctm = db.CodeTaskModels.ToArray()[rndNum.Next(0, db.CodeTaskModels.Count())];
            return View((SingleTask, MultiTask, ctm).ToTuple());
        }
    }
}