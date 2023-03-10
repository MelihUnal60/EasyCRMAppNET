using EasyCRMAppNET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCRMAppNET.App
{
    public interface IOpportunityService
    {
        void CreateOpportunity(int id,string name,string opportunityStatus,string opportunityOwner,string customer, int categoryId);

        bool DeleteOpportunity(int opportunityId);

        bool DeleteOppWithCategory(int categoryId);

        IReadOnlyCollection<Opportunity> GetOpportunities();

        Opportunity UpdateOpportunity(int opportunityId, string newOpportunityName, string opportunityStatus, int categoryId, string customer,string owner);

    }
}
