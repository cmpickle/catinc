namespace catinc.Models.Domain
{
    public class Loyalty
    {
        public int LoyaltyID { get; set; }
        public MyIdentityUser User { get; set; }
        public int LoyaltyPoints { get; set; }
    }
}