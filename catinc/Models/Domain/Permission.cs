namespace catinc.Models.Domain
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public MyIdentityUser User { get; set; }
        public int PermissionLevel { get; set; }
    }
}