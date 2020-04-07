using System;
using System.Collections.Generic;

namespace Pomodoro.Models
{
    public partial class PomodoroUser
    {
        public PomodoroUser()
        {
            UserTask = new HashSet<UserTask>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserTask> UserTask { get; set; }
    }
}
