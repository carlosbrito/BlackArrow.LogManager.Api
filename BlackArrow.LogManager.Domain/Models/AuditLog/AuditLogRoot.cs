using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackArrow.LogManager.Domain.Models.AuditLog
{
    public class AuditLogRoot
    {
        [BsonIgnore]
        public string _id { get; set; }
        public string EventType { get; set; }
        public Environment Environment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public Action Action { get; set; }
        public string UserId { get; set; }
    }
}
