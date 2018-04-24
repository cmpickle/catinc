using System.Collections.Generic;

namespace catinc.Models.Domain
{
    public class Vendor
    {
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorTelephoneNo { get; set; }
        public string VendorEmail { get; set; }
        public decimal VendorPaymentAmount { get; set; }
        public int VendorCreditcardNo { get; set; }
        public bool IsVendorActive { get; set; }
        public bool IsVendorSuspended { get; set; }
        public bool IsVendorDeleted { get; set; }
        public List<VendorUser> VendorUsers { get; set; }
    }
}