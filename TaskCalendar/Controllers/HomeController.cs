using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;

using TaskCalendar.Domain.Core;
using TaskCalendar.Infrastructure.Data.Context;
using TaskCalendar.Infrastructure.Data.Repository;

namespace TaskCalendar.Controllers
{
    public class HomeController : Controller
    {
        private DataBaseContext _dbContext = new DataBaseContext();
        private TaskRepository _taskRepository;

        public HomeController()
        {
            _taskRepository = new TaskRepository(_dbContext);
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.TaskIndexList = new List<int>() { 0, 1, 2, 3, 4 };

            return View(_taskRepository.GetTaskList());
        }

        public ActionResult DeleteModal(int id)
        {
            Task task = _taskRepository.Find(id);

            if (task == null)
            {
                return new HttpStatusCodeResult(400);
            }

            return PartialView("_DeleteModal", task);
        }

        [HttpPost]
        public ActionResult TaskSearch(string title)
        {
            var tasks = _taskRepository.SearchTask(title);
            return View("~/Views/Home/Index.cshtml", tasks);
        }

        [HttpPost]
        public ActionResult DeleteTask(int id)
        {
            Task task = _taskRepository.Find(id);

            if (task == null)
            {
                return new HttpStatusCodeResult(400);
            }

            bool status = _taskRepository.Remove(task);

            /*if (status)
            {
                ViewBag.DeleteStatus = "Запись успешно удалена";
            }
            else
            {
                ViewBag.DeleteStatus = "Не удалось удалить запись";
            }*/

            return Redirect("/");
        }
    }
}