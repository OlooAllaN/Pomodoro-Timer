using Pomodoro.Models;
using Pomodoro.TableEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pomodoro.Services
{
    public class TaskService :ITaskService
    {
        /// <summary>
        /// Database connection context.
        /// </summary>
        private readonly PomodoroTimerContext context;

        /// <summary>
        /// The constructor associated with the task service.
        /// </summary>
        public TaskService(PomodoroTimerContext context)
        {
            this.context = context;
        }

        /// <inheritdoc />
        public Task CreateTask(Task task)
        {
            //context.Task.Add(task);
            //context.SaveChanges();
            return task;
        }

        /// <inheritdoc />
        public Task GetTask(int userId)
        {
            return context.UserTask.Where(x => x.UserId == userId).SingleOrDefault();
        }
    }
}
