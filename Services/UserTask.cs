using System;
using System.Collections.Generic;

namespace Pomodoro.services
{
    public partial class UserTask
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }

        public virtual PomodoroUser User { get; set; }
    }
}
