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
    public class DeleteModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public DeleteModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CategoryC == null)
            {
                return NotFound();
            }
            var categoryc = await _context.CategoryC.FindAsync(id);

            if (categoryc != null)
            {
                CategoryC = categoryc;
                _context.CategoryC.Remove(CategoryC);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
