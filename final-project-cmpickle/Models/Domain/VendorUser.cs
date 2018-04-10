using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class VendorUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorUserID { get; set; }
        [ForeignKey("Vendor")]
        public int VendorID { get; set; }
        [ForeignKey("MyUsers")]
        public int UserID { get; set; }

        public VendorUser() {}

        public VendorUser(int vendorID, int userID)
        {
            VendorID = vendorID;
            UserID = userID;
        }
    }
}