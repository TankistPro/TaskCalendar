using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace TaskCalendar.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}