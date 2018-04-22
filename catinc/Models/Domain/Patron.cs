namespace catinc.Models.Domain
{
    public class Patron
    {
        public int PatronID { get; set; }
        public string PatronFirst { get; set; }
        public string PatronLast { get; set; }
        public string PatronAddress { get; set; }
        public string PatronEmail { get; set; }
        public string PatronTelephoneNo { get; set; }
        public bool IsPatronSuspended { get; set; }
        public bool IsPatronDeleted { get; set; }
        public MyIdentityUser User { get; set; }
    }
}