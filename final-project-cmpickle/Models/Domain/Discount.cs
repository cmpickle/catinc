using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class Discount
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DiscountID { get; set; }
        public DateTime DiscountStart { get; set; }
        public DateTime DiscountEnd { get; set; }
        public bool IsDiscountDeleted { get; set; }
    }
}