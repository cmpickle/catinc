using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models
{
    public class Log
    {
        public int LogID { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
        public DateTime LogTimestamp { get; set; }
        public int LogLevel { get; set; }
        public string LogMessage { get; set; }
    }
}