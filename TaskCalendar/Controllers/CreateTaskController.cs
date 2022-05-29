using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TaskCalendar.Domain.Core;
using TaskCalendar.Infrastructure.Data.Repository;
using TaskCalendar.Infrastructure.Data.Context;

namespace TaskCalendar.Controllers
{
    public class CreateTaskController : Controller
    {
        /*TaskContext db = new TaskContext();*/

        private TaskRepository _taskRepository = new TaskRepository(new DataBaseContext());
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Task entity)
        {
            bool result = _taskRepository.CreateTask(entity);

            if (result)
            {
                return Redirect("/Home");
            }

            return new HttpStatusCodeResult(400);
        }
    }
}