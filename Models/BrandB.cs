namespace Proiect1.Models
{
    public class BrandB
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public ICollection<ToyT>? Toys { get; set; }
    }
}
