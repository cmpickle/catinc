using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_project_cmpickle.Models.Domain
{
    public class Log
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogID { get; set; }
        // [ForeignKey("MyUsers")]
        public int UserID { get; set; }
        public DateTime LogTimestamp { get; set; }
        public int LogLevel { get; set; }
        public string LogMessage { get; set; }
    }
}