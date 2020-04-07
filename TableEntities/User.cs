using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pomodoro.TableEntities
{
    [Table("PomodoroUser")]
    public class User
    {
        /// <summary>
        /// Gets or sets the user Id number.
        /// </summary>

        [Key]
        [Column("UserId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        ///  Gets or sets the user name.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a task associated with a user.
        /// </summary>
        [ForeignKey("UserId")]
        public virtual ICollection<Task> Task { get; set; }

    }
}

