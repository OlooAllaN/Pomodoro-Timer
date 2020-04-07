using Pomodoro.TableEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pomodoro.Services
{
    public interface ITaskService
    {
        /// <summary>
        /// Gets a Task.
        /// </summary>
        /// <param name="UserId">The user id associated with the task.</param>
        /// <returns>returns a user created task</returns>
        Task GetTask(int userId);

        /// <summary>
        /// Creates a new user task. 
        /// </summary>
        /// <param name="task">the task to be created</param>
        /// <returns></returns>
        Task CreateTask(Task task);
    }
}
