using Pomodoro.Models;
using Pomodoro.Services;
using Pomodoro.TableEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pomodoro.UiServices
{
    public class MakePomodoroUiService :IMakePomodoroUiService
    {
        /// <summary>
        /// A class for handling UI backend logic for the application.
        /// </summary>
        /// <summary>
        /// Responsible for accessing data in our user service.
        /// </summary>
        private readonly IUserService lazyUserServices;

        /// <summary>
        /// Responsible for accessing data in our Task service. 
        /// </summary>
        private readonly ITaskService lazyTaskServices;

        /// <summary>
        /// Constructor for dependency injection.
        /// </summary>
        public MakePomodoroUiService(IUserService lazyUserServices, ITaskService lazyTaskServices)
        {
            this.lazyTaskServices = lazyTaskServices;
            this.lazyUserServices = lazyUserServices;

        }

        /// <inheritdoc />
        public Task CreateTask(int userId, string taskText)
        {
            var user = lazyUserServices.GetUser(userId);
            var newTask = new Task
            {
                UserId = user.Id,
                TaskText = taskText,
            };

            var task = lazyTaskServices.CreateTask(newTask);
            return task;
        }

        /// <inheritdoc />
        public User CreateUser(string userName)
        {
            var newUser = new User
            {
                Name = userName,
            };

            var user = lazyUserServices.CreateUser(newUser);
            return user;
        }

        /// <inheritdoc />
        public PomodoroViewModel GetPomdoroTimerView(int? userId)
        {
            if (userId.HasValue)
            {
                var user = lazyUserServices.GetUser(userId.Value);
                var viewModel = new PomodoroViewModel();
                viewModel.Id = user.Id;
                viewModel.UserName = user.Name;
                return viewModel;
            }
            return new PomodoroViewModel();
        }
    }
}

