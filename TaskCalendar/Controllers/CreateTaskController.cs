using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskCalendar.Models;

namespace TaskCalendar.Controllers
{
    public class CreateTaskController : Controller
    {
        TaskContext db = new TaskContext();
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Task entity)
        {

            if (entity == null || string.IsNullOrEmpty(entity.Title))
            {
                return View();
            }

            entity.CreatedAt = DateTime.Now;
            
            try
            {
                db.Tasks.Add(entity);
                db.SaveChanges();

                return Redirect("/Home");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(400);
            }
        }
    }
}