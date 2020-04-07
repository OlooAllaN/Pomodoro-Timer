using Pomodoro.Models;
using Pomodoro.TableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pomodoro.Services
{
    public class UserService :IUserService
    {
        /// <summary>
        /// Database connection context.
        /// </summary>
        private readonly PomodoroTimerContext context;

        /// <summary>
        /// User service constructor
        /// </summary>
        public UserService(PomodoroTimerContext context)
        {
            this.context = context;
        }

        /// <inheritdoc />
        public User CreateUser(User user)
        {
            //context.User.Add(user);
            //context.SaveChanges();
            return user;
        }

        /// <inheritdoc />
        public User GetUserByName(string name)
        {
            return context.PomodoroUser.Where(x => x.Name == name).SingleOrDefault();
        }

        /// <inheritdoc />
        public User GetUser(int id)
        {
            return context.PomodoroUser.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
