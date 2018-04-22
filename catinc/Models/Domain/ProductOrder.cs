namespace catinc.Models.Domain
{
    public class ProductOrder
    {
        public int ProductOrderID { get; set; }
        public Orders order { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }
    }
}