using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models
{
    public class ProductOrder
    {
        public int ProductOrderID { get; set; }
        [ForeignKey("Orders")]
        public int OrderID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}