namespace final_project_cmpickle.Models.Domain
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
        public bool IsvendorDeleted { get; set; }

        public Vendor(string vendorName, string vendorAddress, string vendorTelephoneNo, string vendorEmail, int vendorCreditcardNo)
        {
            VendorName = vendorName;
            VendorAddress = vendorAddress;
            VendorTelephoneNo = vendorTelephoneNo;
            VendorEmail = vendorEmail;
            VendorCreditcardNo = vendorCreditcardNo;
            IsVendorActive = true;
            IsVendorSuspended = false;
            IsvendorDeleted = false;
        }
    }
}