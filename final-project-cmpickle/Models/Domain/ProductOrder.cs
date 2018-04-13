using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class ProductOrder
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductOrderID { get; set; }
        // [ForeignKey("Orders")]
        public Orders order { get; set; }
        public int OrderID { get; set; }
        // [ForeignKey("Product")]
        public Product product { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}