using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesUser.Data;
using RazorPagesUsers.Models;

namespace RazorPagesUser.Pages_Users
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesUser.Data.RazorPagesUserContext _context;

        public IndexModel(RazorPagesUser.Data.RazorPagesUserContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
