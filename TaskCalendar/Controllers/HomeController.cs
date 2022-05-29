using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
/*using TaskCalendar.Models;*/

using TaskCalendar.Domain.Core;
using TaskCalendar.Domain.Interfaces;
using TaskCalendar.Infrastructure.Data.Context;
using TaskCalendar.Infrastructure.Data.Repository;

namespace TaskCalendar.Controllers
{
    public class HomeController : Controller
    {
        /*TaskContext db = new TaskContext();*/

        private TaskRepository _taskRepository = new TaskRepository(new DataBaseContext());


        /*public HomeController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }*/

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.TaskIndexList = new List<int>() { 0, 1, 2, 3, 4 };

            return View(_taskRepository.GetTaskList());
        }

        /*public ActionResult DeleteModal(int id)
        {
            var task = db.Tasks.Find(id);

            return PartialView("_DeleteModal", task);
        }

        [HttpPost]
        public ActionResult DeleteTask(int id)
        {
            Task task = db.Tasks.Find(id);

            if (task == null)
            {
                return new HttpStatusCodeResult(400);
            }

            try
            {
                db.Tasks.Remove(task);
                db.SaveChanges();

                ViewBag.DeleteStaus = "Запись успешно удалена";
            }
            catch (Exception ex)
            {
                ViewBag.DeleteStaus = "Не удалось удалить запись";
            }

            return Redirect("/");
        }*/
    }
}