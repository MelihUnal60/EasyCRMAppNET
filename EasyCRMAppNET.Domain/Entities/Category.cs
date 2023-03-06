using EasyCRMAppNET.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCRMAppNET.Domain.Entities
{
    public sealed class Category:BaseEntity
    {
        public string Name { get; set; }

        public List<Opportunity> Opportunities { get; set; }
    }
}
