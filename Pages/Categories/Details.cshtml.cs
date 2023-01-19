using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect1.Data;
using Proiect1.Models;

namespace Proiect1.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public DetailsModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

      public CategoryC CategoryC { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CategoryC == null)
            {
                return NotFound();
            }

            var categoryc = await _context.CategoryC.FirstOrDefaultAsync(m => m.ID == id);
            if (categoryc == null)
            {
                return NotFound();
            }
            else 
            {
                CategoryC = categoryc;
            }
            return Page();
        }
    }
}
