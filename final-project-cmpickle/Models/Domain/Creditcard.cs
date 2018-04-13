using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class Creditcard
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreditcardID { get; set; }
        public int CreditcardNo { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CCV { get; set; }
    }
}