using System;
using System.Collections.Generic;
using System.Text;

namespace BlackArrow.LogManager.Domain.Models.AuditLog
{
    public class Environment
    {
        public string UserName { get; set; }
        public string MachineName { get; set; }
        public string DomainName { get; set; }
        public string CallingMethodName { get; set; }
        public string AssemblyName { get; set; }
        public string Culture { get; set; }
    }
}
