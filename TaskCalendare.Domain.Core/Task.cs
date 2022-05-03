using System;
using System.ComponentModel.DataAnnotations;

namespace TaskCalendare.Domain.Core
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
