using System;

namespace final_project_cmpickle.Models
{
    public class Orders
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderTimestamp { get; set; }
        public int DiscountID { get; set; }
    }
}