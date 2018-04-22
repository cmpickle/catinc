namespace catinc.Models.Domain
{
    public class PatronCreditcard
    {
        public int PatronCreditcardID { get; set; }
        public Patron Patron { get; set; }
        public Creditcard Creditcard { get; set; }
    }
}