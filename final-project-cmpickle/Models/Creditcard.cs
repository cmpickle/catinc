using System;

namespace final_project_cmpickle.Models
{
    public class Creditcard
    {
        public int CreditcardID { get; set; }
        public int CreditcardNo { get; set; }
        public DateTime EpirationDate { get; set; }
        public int CCV { get; set; }
    }
}