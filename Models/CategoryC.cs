namespace Proiect1.Models
{
    public class CategoryC
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public ICollection<ToyT>? Toys { get; set; }
    }
}
