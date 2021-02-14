using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackArrow.LogManager.Domain.Models.AuditLog
{
    [BsonIgnoreExtraElements]
    public class RequestBody
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public int Lenght { get; set; }
        
    }
}
