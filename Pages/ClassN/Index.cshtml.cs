using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myWebApp.Data;
using myWebApp.Models;

namespace myWebApp.Pages.ClassN
{
    public class IndexModel : PageModel
    {
        private readonly myWebApp.Data.myWebAppContext _context;

        public IndexModel(myWebApp.Data.myWebAppContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
