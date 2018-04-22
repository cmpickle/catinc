namespace catinc.Models.Domain
{
    public class VendorUser
    {
        public int VendorUserId { get; set; }
        public Vendor Vendor { get; set; }
        public MyIdentityUser User { get; set; }
    }
}