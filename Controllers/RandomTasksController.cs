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
            MultiChoiseModel mcm = DBContext.MultiChoiseModels.ToArray()[rndNum.Next(0, DBContext.MultiChoiseModels.Count())];
            Tuple<string, Task[]> MultiTask = Tuple.Create(mcm.Statement, JsonConvert.DeserializeObject<Task[]>(mcm.Options));
            return MultiTask;
        }

        private Tuple<string, Task[]> GetSingleTask()
        {
            SingleChoiseModel scm = DBContext.SingleChoiseModels.ToArray()[rndNum.Next(0, DBContext.SingleChoiseModels.Count())];
            Tuple<string, Task[]> SingleTask = Tuple.Create(scm.Statement, JsonConvert.DeserializeObject<Task[]>(scm.Options));
            return SingleTask;
        }
        private CodeTaskModel GetCodeTask() =>
            DBContext.CodeTaskModels.ToArray()[rndNum.Next(0, DBContext.CodeTaskModels.Count())];

        public ActionResult EasyTest()
        {
            Tuple<string, Task[]> SingleTask = GetSingleTask();
            Tuple<string, Task[]> MultiTask = GetMultiTask();
            return View((SingleTask, MultiTask, GetCodeTask()).ToTuple());
        }

        private void FillMultiTasks(Tuple<string, Task[]>[] MultiTasks)
        {
            byte arrayCount = 0;
            while (arrayCount != MultiTasks.Length)
            {
                Tuple<string, Task[]> mcmTuple = GetMultiTask();
                if (!MultiTasks.Contains(mcmTuple))
                {
                    MultiTasks[arrayCount++] = mcmTuple;
                }
            }
        }

        private void FillSingleTasks(Tuple<string, Task[]>[] SingleTasks)
        {
            byte arrayCount = 0;
            while (arrayCount != SingleTasks.Length)
            {
                Tuple<string, Task[]> scmTuple = GetSingleTask();
                if (!SingleTasks.Contains(scmTuple))
                {
                    SingleTasks[arrayCount++] = scmTuple;
                }
            }
        }

        public ActionResult MediumTest()
        {
            Tuple<string, Task[]>[] SingleTasks = new Tuple<string, Task[]>[3];
            Tuple<string, Task[]>[] MultiTasks = new Tuple<string, Task[]>[2];
            FillSingleTasks(SingleTasks);
            FillMultiTasks(MultiTasks);
            CodeTaskModel ctm = DBContext.CodeTaskModels.ToArray()[rndNum.Next(0, DBContext.CodeTaskModels.Count())];
            return View((SingleTasks, MultiTasks, ctm).ToTuple());
        }

        private void FillCodeTasks(CodeTaskModel[] CodeTasks)
        {
            byte arrayCount = 0;
            while (arrayCount != CodeTasks.Length)
            {
                CodeTaskModel CodeTask = GetCodeTask();
                if (!CodeTasks.Contains(CodeTask))
                {
                    CodeTasks[arrayCount++] = CodeTask;
                }
            }
        }

        public ActionResult HardTest()
        {
            Tuple<string, Task[]>[] SingleTasks = new Tuple<string, Task[]>[7];
            Tuple<string, Task[]>[] MultiTasks = new Tuple<string, Task[]>[5];
            CodeTaskModel[] CodeTasks = new CodeTaskModel[3];
            FillSingleTasks(SingleTasks);
            FillMultiTasks(MultiTasks);
            FillCodeTasks(CodeTasks);
            return View((SingleTasks, MultiTasks, CodeTasks).ToTuple());
        }
    }
}