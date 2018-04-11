using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using final_project_cmpickle.Models.MemberSystem;

namespace final_project_cmpickle.Models.Domain
{
    public class VendorUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorUserID { get; set; }
        // [ForeignKey("Vendor")]
        public Vendor Vendor { get; set; }
        public int VendorID { get; set; }
        // [ForeignKey("MyUsers")]
        [NotMapped]
        public ClaimsPrincipal User { get; set; }
        public int UserID { get; set; }

        public VendorUser() {}

        public VendorUser(int vendorID, int userID)
        {
            VendorID = vendorID;
            UserID = userID;
        }
    }
}