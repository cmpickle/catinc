using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class Vendor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        public Vendor()
        {
            IsVendorActive = true;
            IsVendorDeleted = false;
            IsVendorSuspended = false;
        }

        public Vendor(string vendorName, string vendorAddress, string vendorTelephoneNo, string vendorEmail, int vendorCreditcardNo)
        {
            VendorName = vendorName;
            VendorAddress = vendorAddress;
            VendorTelephoneNo = vendorTelephoneNo;
            VendorEmail = vendorEmail;
            VendorCreditcardNo = vendorCreditcardNo;
            IsVendorActive = true;
            IsVendorSuspended = false;
            IsVendorDeleted = false;
        }
    }
}