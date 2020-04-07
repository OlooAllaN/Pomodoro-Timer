using Pomodoro.TableEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pomodoro.Models
{
    public class PomodoroViewModel
    {

        /// <summary>
        /// Gets or sets the user Id number.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///  Gets or sets the user name.
        /// </summary>
        public Task Task { get; set; }
    }
}
