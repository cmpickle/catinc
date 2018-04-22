namespace catinc.Models.Domain
{
   public class VendorUserPermission
    {
        public int VendorUserPermissionID { get; set; }
        public int VendorUserID { get; set; }
        public int PermissionLevel { get; set; }
    } 
}