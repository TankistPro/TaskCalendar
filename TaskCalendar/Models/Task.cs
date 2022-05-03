using System;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TaskCalendar.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}