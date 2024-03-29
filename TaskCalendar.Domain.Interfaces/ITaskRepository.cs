﻿using System;
using System.Collections.Generic;
using TaskCalendar.Domain.Core;

namespace TaskCalendar.Domain.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<Task> GetTaskList();
        IEnumerable<Task> SearchTask(string text);
        bool CreateTask(Task entity);
        bool DeleteTask(int id);
        Task Find(int id);
        bool Remove(Task entity);
    }
}
