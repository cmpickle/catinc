using System;
using System.Collections.Generic;

namespace catinc.Models.Domain
{
    public class Orders
    {
        public int OrderID { get; set; }
        public DateTime OrderTimestamp { get; set; }
        public MyIdentityUser User { get; set; }
        public Discount Discount { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
    }
}