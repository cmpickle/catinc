using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models
{
    public class Loyalty
    {
        public int LoyaltyID { get; set; }
        [ForeignKey("MyUsers")]
        public int UserID { get; set; }
        public int LoyaltyPoints { get; set; }
    }
}