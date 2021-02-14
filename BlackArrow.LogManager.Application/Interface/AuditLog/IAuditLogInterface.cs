using System;
using System.Collections.Generic;
using System.Text;

namespace BlackArrow.LogManager.Application.Interface.AuditLog
{
    public interface IAuditLogInterface
    {
        List<Domain.Models.AuditLog.AuditLogRoot> GetAuditLog();
    }
}
