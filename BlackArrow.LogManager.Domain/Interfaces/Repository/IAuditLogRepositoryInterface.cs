using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackArrow.LogManager.Domain.Interfaces.Repository
{
    public interface IAuditLogRepositoryInterface
    {
        List<Models.AuditLog.AuditLogRoot> GetAuditLog();
    }
}
