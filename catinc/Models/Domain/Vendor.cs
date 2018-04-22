using System.Collections.Generic;

namespace catinc.Models.Domain
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public List<VendorUser> VendorUsers { get; set; }
    }
}