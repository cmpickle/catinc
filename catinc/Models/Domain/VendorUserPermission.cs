namespace catinc.Models.Domain
{
   public class VendorUserPermission
    {
        public int VendorUserPermissionID { get; set; }
        public VendorUser VendorUser { get; set; }
        public int PermissionLevel { get; set; }
    } 
}