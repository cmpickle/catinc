using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
        public DateTime OrderTimestamp { get; set; }
        [ForeignKey("Discount")]
        public int DiscountID { get; set; }
    }
}