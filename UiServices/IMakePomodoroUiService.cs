using Pomodoro.Models;
using Pomodoro.TableEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pomodoro.UiServices
{
    public interface IMakePomodoroUiService
    {
        /// <summary>
        /// A view model for creating a pomdoro timer view.
        /// </summary>
        /// <param name="userId">the user Id.</param>
        /// <returns></returns>
        PomodoroViewModel GetPomdoroTimerView(int? userId);

        /// <summary>
        /// Creates a new user task.
        /// <param name="userId">the user Id.</param>
        /// <param name="taskText">the task text.</param>
        /// </summary>
        Task CreateTask(int userId, string taskText);

        /// <summary>
        /// Creates a new pomdoro timer user.
        /// <param name="userName">the user name.</param>
        /// </summary>
        User CreateUser(string userName);
    }
}
