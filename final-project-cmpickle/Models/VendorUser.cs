using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models
{
    public class VendorUser
    {
        public int VendorUserID { get; set; }
        [ForeignKey("Vendor")]
        public int VendorID { get; set; }
        [ForeignKey("MyUsers")]
        public int UserID { get; set; }
    }
}