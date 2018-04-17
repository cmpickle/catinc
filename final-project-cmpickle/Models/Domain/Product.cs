using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class Product
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public string ProductSKU { get; set; }
        public string ProductName { get; set; }
        public string ProductShortDescription { get; set; }
        public string ProductLongDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductInventory {get; set; }
        public string ProductImageURL { get; set; }
        public DateTime ProductExpirationDate { get; set; }
        public bool IsProductedDeleted { get; set; }
        public Vendor Vendor { get; set; }
        public int VendorID { get; set; }
    }
}