using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Pomodoro.TableEntities;

namespace Pomodoro.Models
{
    public partial class PomodoroTimerContext : DbContext
    {

        public PomodoroTimerContext(DbContextOptions<PomodoroTimerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> PomodoroUser { get; set; }
        public virtual DbSet<Task> UserTask { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("uid=sqlserver;Pwd=admin;server=tcp:35.192.99.144;Database=PomodoroTimer;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.TaskName).IsRequired();

                entity.Property(e => e.TaskText).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.UserId);
            });

        }
    }
}
