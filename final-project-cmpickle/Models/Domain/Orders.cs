using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class Orders
    {
        // [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        // [ForeignKey("MyUsers")]
        public int UserID { get; set; }
        public DateTime OrderTimestamp { get; set; }
        // [ForeignKey("Discount")]
        public int DiscountID { get; set; }
    }
}