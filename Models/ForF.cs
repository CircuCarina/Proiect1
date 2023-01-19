namespace Proiect1.Models
{
    public class ForF
    {
        public int ID { get; set; }
        public string For { get; set; }
        public ICollection<ToyT>? Toys { get; set; }
    }
}
