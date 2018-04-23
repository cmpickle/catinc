using System;

namespace catinc.Models.Domain
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public DateTime DiscountStart { get; set; }
        public DateTime DiscountEnd { get; set; }
        public bool IsDiscountDeleted { get; set; }
    }
}