using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackArrow.LogManager.Domain.Models.AuditLog
{
    [BsonIgnoreExtraElements]
    public class ActionParameters
    {
        public string id { get; set; }
        public string filter { get; set; }
        public string fundId { get; set; }
        public string sellerFundId { get; set; }
        public int pageSize { get; set; }
        
    }
}
