using EasyCRMAppNET.Domain.Entities;
using EasyCRMAppNET.Domain.Interfaces;
using EasyCRMAppNET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCRMAppNET.App
{
    internal class OpportunityService : IOpportunityService
    {
        private readonly IRepository<Opportunity> _opportunityRepository;

        public OpportunityService()
        {
            _opportunityRepository = IOCContainer.Resolve<IRepository<Opportunity>>();
        }

        public void CreateOpportunity(int id, string name, string opportunityStatus, string opportunityOwner, string customer)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Fırsat adı boş olamaz!!");

            var oldOpportunity = _opportunityRepository.GetList().FirstOrDefault(x => x.Name == name);
            if (oldOpportunity != null)
                return;

            Opportunity opportunity= new Opportunity();
            opportunity.Id = id;
            opportunity.Name = name;
            opportunity.Status = opportunityStatus;
            opportunity.Owner = opportunityOwner;
            opportunity.Customer= customer;
            opportunity.CreatedDate= DateTime.Now;
            _opportunityRepository.Add(opportunity);
        }

        public bool DeleteOpportunity(int opportunityId)
        {
            return _opportunityRepository.Remove(opportunityId);
        }

        public IReadOnlyCollection<Opportunity> GetOpportunities()
        {
            return _opportunityRepository.GetList().ToList().AsReadOnly();
        }

        public Opportunity UpdateOpportunity(int opportunityId, string newOpportunityName, string opportunityStatus)
        {
            if (string.IsNullOrWhiteSpace(newOpportunityName))
                throw new ArgumentNullException("Fırsat adı boş olamaz!!");

            var opportunity = new Opportunity();
            opportunity.Id = opportunityId;
            opportunity.Name = newOpportunityName;
            opportunity.Status  = opportunityStatus;
            opportunity.UpdatedDate= DateTime.Now;
            return _opportunityRepository.Update(opportunityId, opportunity);
        }

        
    }
}
