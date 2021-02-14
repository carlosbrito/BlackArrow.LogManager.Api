using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackArrow.LogManager.Domain.Models.AuditLog
{
    [BsonIgnoreExtraElements]
    public class Headers
    {
        [JsonProperty("Cache-Control")]
        public string CacheControl { get; set; }
        public string Pragma { get; set; }
        public string Accept { get; set; }
        [JsonProperty("Accept-Encoding")]
        public string AcceptEncoding { get; set; }
        [JsonProperty("Accept-Language")]
        public string AcceptLanguage { get; set; }
        public string Authorization { get; set; }
        public string Host { get; set; }
        public string Referer { get; set; }
        [JsonProperty("User-Agent")]
        public string UserAgent { get; set; }
        public string Origin { get; set; }
        [JsonProperty("X-Forwarded-For")]
        public string XForwardedFor { get; set; }
        [JsonProperty("X-Forwarded-Proto")]
        public string XForwardedProto { get; set; }
        [JsonProperty("X-Forwarded-Port")]
        public string XForwardedPort { get; set; }
        [JsonProperty("X-Amzn-Trace-Id")]
        public string XAmznTraceId { get; set; }
        [JsonProperty("sec-fetch-site")]
        public string SecFetchSite { get; set; }
        [JsonProperty("sec-fetch-mode")]
        public string SecFetchMode { get; set; }
        [JsonProperty("sec-fetch-dest")]
        public string SecFetchDest { get; set; }
    }
}
