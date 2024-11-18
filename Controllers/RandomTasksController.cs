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
        private Tuple<string, Task[]> GetMultiTask()
        {
            MultiChoiseModel mcm = db.MultiChoiseModels.ToArray()[rndNum.Next(0, db.MultiChoiseModels.Count())];
            Tuple<string, Task[]> MultiTask = Tuple.Create(mcm.Statement, JsonConvert.DeserializeObject<Task[]>(mcm.Options));
            return MultiTask;
        }

        private Tuple<string, Task[]> GetSingleTask()
        {
            SingleChoiseModel scm = db.SingleChoiseModels.ToArray()[rndNum.Next(0, db.SingleChoiseModels.Count())];
            Tuple<string, Task[]> SingleTask = Tuple.Create(scm.Statement, JsonConvert.DeserializeObject<Task[]>(scm.Options));
            return SingleTask;
        }
        public ActionResult EasyTest()
        {
            Tuple<string, Task[]> SingleTask = GetSingleTask();
            Tuple<string, Task[]> MultiTask = GetMultiTask();
            CodeTaskModel ctm = db.CodeTaskModels.ToArray()[rndNum.Next(0, db.CodeTaskModels.Count())];
            return View((SingleTask, MultiTask, ctm).ToTuple());
        }

        public ActionResult MediumTest()
        {
            Tuple<string, Task[]>[] SingleTasks = new Tuple<string, Task[]>[3];
            Tuple<string, Task[]>[] MultiTasks = new Tuple<string, Task[]>[2];
            byte arrayCount = 0;
            while (arrayCount != SingleTasks.Length)
            {
                Tuple<string, Task[]> scmTuple = GetSingleTask();
                if (!SingleTasks.Contains(scmTuple))
                {
                    SingleTasks[arrayCount++] = scmTuple;
                }
            }
            arrayCount = 0;
            while (arrayCount != MultiTasks.Length)
            {
                Tuple<string, Task[]> mcmTuple = GetMultiTask();
                if (!MultiTasks.Contains(mcmTuple))
                {
                    MultiTasks[arrayCount++] = mcmTuple;
                }
            }
            CodeTaskModel ctm = db.CodeTaskModels.ToArray()[rndNum.Next(0, db.CodeTaskModels.Count())];
            return View((SingleTasks, MultiTasks, ctm).ToTuple());
        }
    }
}