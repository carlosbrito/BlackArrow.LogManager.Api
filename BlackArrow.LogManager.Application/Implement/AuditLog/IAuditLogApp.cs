using BlackArrow.LogManager.Application.Interface.AuditLog;
using BlackArrow.LogManager.Domain.Interfaces.Repository;
using BlackArrow.LogManager.Domain.Models.AuditLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackArrow.LogManager.Application.Implement.AuditLog
{
    public class IAuditLogApp : IAuditLogInterface
    {
        private readonly IAuditLogRepositoryInterface _auditLogRepositoryInterface;
        public IAuditLogApp(IAuditLogRepositoryInterface auditLogRepositoryInterface)
        {
            _auditLogRepositoryInterface = auditLogRepositoryInterface;
        }


        public List<AuditLogRoot> GetAuditLog()
        {
            return _auditLogRepositoryInterface.GetAuditLog();
        }
    }
}
