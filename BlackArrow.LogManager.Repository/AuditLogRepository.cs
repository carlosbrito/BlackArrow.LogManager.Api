using BlackArrow.LogManager.Domain.Interfaces.Repository;
using BlackArrow.LogManager.Domain.Models.AuditLog;
using BlackArrow.LogManager.SharedKernell;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackArrow.LogManager.Repository.MongoDB
{
    public class AuditLogRepository : MongoContextConfig, IAuditLogRepositoryInterface
    {
        public IMongoCollection<AuditLogRoot> _auditLogs;

        public List<AuditLogRoot> GetAuditLog()
        {

            MongoDefaults.GuidRepresentation = GuidRepresentation.Standard;
            var client = new MongoClient("");
            var database = client.GetDatabase("");


            _auditLogs = database.GetCollection<AuditLogRoot>("AuditLogs");

            var teste = _auditLogs.Find(x => true).Limit(10).ToList();

            return teste;
        }
    }
}
