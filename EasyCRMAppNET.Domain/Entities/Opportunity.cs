using EasyCRMAppNET.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCRMAppNET.Domain.Entities
{
    public sealed class Opportunity:AuditEntity
    {
        public string Name { get; set; }

        public string Customer { get; set; }

        public string Status { get; set; }

        public string Owner { get; set; }

        public int CategoryId { get; set; }
    }
}
