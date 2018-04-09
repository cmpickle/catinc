using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class Loyalty
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoyaltyID { get; set; }
        [ForeignKey("MyUsers")]
        public int UserID { get; set; }
        public int LoyaltyPoints { get; set; }
    }
}