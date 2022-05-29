﻿using System;
using System.Collections.Generic;
using TaskCalendar.Domain.Core;
using TaskCalendar.Domain.Interfaces;
using TaskCalendar.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace TaskCalendar.Infrastructure.Data.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private DataBaseContext _db;

        public TaskRepository(DataBaseContext context)
        {
            _db = context;
        }
        
        public bool CreateTask(Task entity)
        {
            if (entity == null || string.IsNullOrEmpty(entity.Title))
            {
                return false;
            }

            entity.CreatedAt = DateTime.Now;

            try
            {
                _db.Tasks.Add(entity);
                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteTask(int id)
        {
            Task task = _db.Tasks.Find(id);

            if (task == null)
            {
                return false;
            }

            try
            {
                _db.Tasks.Remove(task);
                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Task> GetTaskList()
        {
            return _db.Tasks;
        }
    }
}