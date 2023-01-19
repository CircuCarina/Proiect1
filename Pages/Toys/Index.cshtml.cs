using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

        public IList<ToyT> ToyT { get; set; } = default!;
        public string ToySort { get; set; }
        public string CategorySort { get; set; }
        public string CurrentFilter { get; set; }
        public async Task OnGetAsync(string sortOrder)
        {
            ToySort = String.IsNullOrEmpty(sortOrder) ? "toy_desc" : "";
            CategorySort = String.IsNullOrEmpty(sortOrder) ? "category_desc" : "";

            if (_context.ToyT != null)
            {
                ToyT = await _context.ToyT
                    .Include(a => a.For)
                    .Include(a => a.Category)
                    .Include(a => a.Brand)
                    .ToListAsync();
            }
            switch (sortOrder)
            {
                case "toy_desc":
                    ToyData.Toys = ToyData.Toys.OrderByDescending(s =>
                   s.Toy);
                    break;
                case "category_desc":
                    ToyData.Toys = ToyData.Toys.OrderByDescending(s =>
                   s.Category);
                    break;
            }
        }
    }
}