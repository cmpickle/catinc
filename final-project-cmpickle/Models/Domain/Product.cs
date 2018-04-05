using System;

namespace final_project_cmpickle.Models.Domain
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductSKU { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductInventory {get; set; }
        public DateTime ProductExpirationDate { get; set; }
        public bool IsProductedDeleted { get; set; }
    }
}