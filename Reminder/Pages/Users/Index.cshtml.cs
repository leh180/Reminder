using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Reminder.Data;
using Reminder.Model;

namespace Reminder.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Reminder.Data.ReminderContext _context;

        public IndexModel(Reminder.Data.ReminderContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
