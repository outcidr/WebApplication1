namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<Product> OrderedProducts { get; set; }
    }
}
