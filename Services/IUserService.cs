using Pomodoro.TableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pomodoro.Services
{
    public interface IUserService
    {

        /// <summary>
        /// Gets the user associated with the pomodoro timer.
        /// </summary>
        /// <param name="Id">The user Id.</param>
        /// <returns></returns>
        User GetUser(int Id);

        /// <summary>
        /// Gets the user by name.
        /// </summary>
        /// <param name="name">The user name.</param>
        /// <returns></returns>
        User GetUserByName(string name);

        /// <summary>
        /// Creates a new user. 
        /// </summary>
        /// <param name="user">the user to be created.</param>
        /// <returns></returns>
        User CreateUser(User user);
    }
}
