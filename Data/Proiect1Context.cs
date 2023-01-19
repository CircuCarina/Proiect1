using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect1.Models;

namespace Proiect1.Data
{
    public class Proiect1Context : DbContext
    {
        public Proiect1Context (DbContextOptions<Proiect1Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect1.Models.ToyT> ToyT { get; set; } = default!;

        public DbSet<Proiect1.Models.BrandB> BrandB { get; set; }

        public DbSet<Proiect1.Models.ForF> ForF { get; set; }

        public DbSet<Proiect1.Models.CategoryC> CategoryC { get; set; }
    }
}
