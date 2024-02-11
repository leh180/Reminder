using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reminder.Model;

namespace Reminder.Data
{
    public class ReminderContext : DbContext
    {
        public ReminderContext (DbContextOptions<ReminderContext> options)
            : base(options)
        {
        }

        public DbSet<Reminder.Model.User> User { get; set; } = default!;
    }
}
