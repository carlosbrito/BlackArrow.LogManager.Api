using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackArrow.LogManager.Domain.Models.AuditLog
{
    [BsonIgnoreExtraElements]
    public class Action
    {
        public string TraceId { get; set; }
        public string HttpMethod { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public ActionParameters ActionParameters { get; set; }
        public string RequestUrl { get; set; }
        public string IpAddress { get; set; }
        public string ResponseStatus { get; set; }
        public int ResponseStatusCode { get; set; }
        public RequestBody RequestBody { get; set; }
        //public ResponseBody ResponseBody { get; set; }
        public Headers Headers { get; set; }
        public bool ModelStateValid { get; set; }
    }
}
