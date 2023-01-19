using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect1.Data;
using Proiect1.Models;

namespace Proiect1.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public EditModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public CategoryC CategoryC { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CategoryC == null)
            {
                return NotFound();
            }

            var categoryc =  await _context.CategoryC.FirstOrDefaultAsync(m => m.ID == id);
            if (categoryc == null)
            {
                return NotFound();
            }
            CategoryC = categoryc;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CategoryC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryCExists(CategoryC.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CategoryCExists(int id)
        {
          return _context.CategoryC.Any(e => e.ID == id);
        }
    }
}
