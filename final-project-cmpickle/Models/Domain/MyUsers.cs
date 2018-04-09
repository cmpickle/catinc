using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class MyUsers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [ForeignKey("IdentityUser")]
        public int IdentityUserID { get; set; }
        // public string Username { get; set; }
        // public string UserHash { get; set; }
        // public string Salt { get; set; }
        public bool IsUserDeleted { get; set; }
    }
}