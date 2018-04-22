namespace catinc.Models.Domain
{
    public class Log
    {
        public int LogID { get; set; }
        public MyIdentityUser User { get; set; }
        public DateTime LogTimestamp { get; set; }
        public int LogLevel { get; set; }
        public string LogMessage { get; set; }
    }
}