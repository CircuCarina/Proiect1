﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect1.Data;
using Proiect1.Models;

namespace Proiect1.Pages.For
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect1.Data.Proiect1Context _context;

        public DetailsModel(Proiect1.Data.Proiect1Context context)
        {
            _context = context;
        }

      public ForF ForF { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ForF == null)
            {
                return NotFound();
            }

            var forf = await _context.ForF.FirstOrDefaultAsync(m => m.ID == id);
            if (forf == null)
            {
                return NotFound();
            }
            else 
            {
                ForF = forf;
            }
            return Page();
        }
    }
}
