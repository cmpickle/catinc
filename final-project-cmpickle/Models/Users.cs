namespace final_project_cmpickle.Models
{
    public class Users
    {
        public int UserID { get; set; }
        public int IdentityUserId { get; set; }
        // public string Username { get; set; }
        // public string UserHash { get; set; }
        // public string Salt { get; set; }
        public bool IsUserDeleted { get; set; }
    }
}