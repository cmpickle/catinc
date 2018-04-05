using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models
{
    public class Permission
    {
        public int PermissionID { get; set; }
        [ForeignKey("MyUsers")]
        public int UserID { get; set; }
        public int PermissionLevel { get; set; }
    }
}