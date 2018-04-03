using System;

namespace final_project_cmpickle.Models
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public DateTime DiscountStart { get; set; }
        public DateTime DiscountEnd { get; set; }
        public bool IsDiscountDeleted { get; set; }
    }
}