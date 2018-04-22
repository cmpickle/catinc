namespace catinc.Models.Domain
{
    public class Orders
    {
        public int OrderID { get; set; }
        public MyIdentityUser User { get; set; }
        public DateTime OrderTimestamp { get; set; }
        public int DiscountID { get; set; }
    }
}