using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackArrow.LogManager.Domain.Models.AuditLog
{
    public class Headers
    {
        public string Connection { get; set; }
        [JsonProperty("Accept-Encoding")]
        public string AcceptEncoding { get; set; }
        public string Host { get; set; }
        [JsonProperty("User-Agent")]
        public string UserAgent { get; set; }
    }
}
