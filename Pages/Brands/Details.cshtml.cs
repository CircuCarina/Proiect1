using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect1.Data;
using Proiect1.Models;

namespace Proiect1.Pages.Brands
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public DetailsModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

      public BrandB BrandB { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BrandB == null)
            {
                return NotFound();
            }

            var brandb = await _context.BrandB.FirstOrDefaultAsync(m => m.ID == id);
            if (brandb == null)
            {
                return NotFound();
            }
            else 
            {
                BrandB = brandb;
            }
            return Page();
        }
    }
}
