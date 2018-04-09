using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class PatronCreditcard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatronCreditcardID { get; set; }
        [ForeignKey("Patron")]
        public int PatronID { get; set; }
        [ForeignKey("Creditcard")]
        public int CreditcardID { get; set; }
    }
}