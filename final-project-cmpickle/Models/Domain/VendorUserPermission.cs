using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class VendorUserPermission
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorUserPermissionID { get; set; }
        // [ForeignKey("Vendor")]
        public int VendorUserID { get; set; }
        // [ForeignKey("VendorUser")]
        public int PermissionLevel { get; set; }
    }
}