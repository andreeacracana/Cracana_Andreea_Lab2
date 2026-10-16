using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cracana_Andreea_Lab2.Models;

namespace Cracana_Andreea_Lab2.Pages_Authors
{
    public class IndexModel : PageModel
    {
        private readonly Cracana_Andreea_Lab2Context _context;

        public IndexModel(Cracana_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
