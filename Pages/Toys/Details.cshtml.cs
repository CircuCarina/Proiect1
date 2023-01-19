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
    public class DetailsModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public DetailsModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

      public ToyT ToyT { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ToyT == null)
            {
                return NotFound();
            }

            var toyt = await _context.ToyT.FirstOrDefaultAsync(m => m.ID == id);
            if (toyt == null)
            {
                return NotFound();
            }
            else 
            {
                ToyT = toyt;
            }
            return Page();
        }
    }
}
