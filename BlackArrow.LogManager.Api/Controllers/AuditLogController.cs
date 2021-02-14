using BlackArrow.LogManager.Application.Interface.AuditLog;
using BlackArrow.LogManager.Domain.Models.AuditLog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackArrow.LogManager.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuditLogController : ControllerBase
    {

        private readonly IAuditLogInterface _auditLogInterface;
        private readonly ILogger<WeatherForecastController> _logger;

        public AuditLogController(ILogger<WeatherForecastController> logger, IAuditLogInterface auditLogInterface)
        {
            _logger = logger;
            _auditLogInterface = auditLogInterface;
        }

        [HttpGet]
        public List<AuditLogRoot> Get()
        {
            var audits = _auditLogInterface.GetAuditLog();

            return audits;
        }
    }

}
