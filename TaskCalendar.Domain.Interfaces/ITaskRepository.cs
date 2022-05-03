using System;
using System.Collections.Generic;
using TaskCalendare.Domain.Core;

namespace TaskCalendar.Domain.Interfaces
{
    public interface ITaskRepository: IDisposable
    {
        IEnumerable<Task> GetTaskList();
        bool CreateTask(Task entity);
        bool DeleteTask(Task entity);
    }
}
