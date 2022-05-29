using System;
using System.Collections.Generic;
using TaskCalendar.Domain.Core;

namespace TaskCalendar.Domain.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetTaskList();
        bool CreateTask(Task entity);
        bool DeleteTask(int id);
    }
}
