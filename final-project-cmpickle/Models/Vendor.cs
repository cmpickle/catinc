namespace final_project_cmpickle.Models
{
    public class Vendor
    {
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorTelephoneNo { get; set; }
        public string VendorEmail { get; set; }
        public decimal VendorPaymentAmount { get; set; }
        public int VendorCreditCardNo { get; set; }
        public bool IsVendorActive { get; set; }
        public bool IsVendorSuspended { get; set; }
        public bool IsvendorDeleted { get; set; }
    }
}