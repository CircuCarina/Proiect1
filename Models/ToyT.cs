using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Proiect1.Models
{
    public class ToyT
    {
        public int ID { get; set; }
        public string Toy { get; set; }
        public int? ForID { get; set; }
        public ForF? For { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }
        public CategoryC? Category { get; set; }
        public int? BrandID { get; set; }
        public BrandB? Brand { get; set; }
    }
}