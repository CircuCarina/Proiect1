using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect1.Data;
using Proiect1.Models;

namespace Proiect1.Pages.Toys
{
    public class IndexModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public IndexModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

        public IList<ToyT> ToyT { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ToyT != null)
            {
                ToyT = await _context.ToyT
                    .Include(b => b.Brand)
                    .ToListAsync();
            }
        }
    }
}
