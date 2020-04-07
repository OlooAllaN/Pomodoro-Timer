using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pomodoro.TableEntities
{
    [Table("UserTask")]
    public class Task
    {

        /// <summary>
        /// Gets or sets the task Id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskId { get; set; }

        /// <summary>
        /// Gets or sets the task name.
        /// </summary>
        [Column("Name")]
        [Required]
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or sets the task text.
        /// </summary>
        [Column("Text")]
        [Required]
        public string TaskText { get; set; }

        /// <summary>
        /// Gets or sets the Task status.
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Gets or sets the user Id associated with the task.
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        ///  Gets or sets the task associated with the user.
        /// </summary>
        public User User { get; set; }
    }
}
