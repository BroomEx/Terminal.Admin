using System;
using Terminal.Admin.Data.Models.Shared;

namespace Terminal.Admin.Data.Models
{
    public class ApplicationLog: Entity
    {
        public string Message { get; set; }
        public string Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Exception { get; set; }
        public string LogEvent { get; set; }
        public string Component { get; set; }
        public string ErrorCode { get; set; }
    }
}
