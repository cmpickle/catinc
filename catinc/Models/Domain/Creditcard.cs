using System;
using System.Collections.Generic;

namespace catinc.Models.Domain
{
    public class Creditcard
    {
        public int CreditcardID { get; set; }
        public int CreditcardNo { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CCV { get; set; }
        public List<PatronCreditcard> PatronCreditcards { get; set; }
    }
}