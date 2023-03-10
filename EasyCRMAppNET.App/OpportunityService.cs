using EasyCRMAppNET.Domain.Entities;
using EasyCRMAppNET.Domain.Interfaces;
using EasyCRMAppNET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        public void CreateOpportunity(int id, string name, string opportunityStatus, string opportunityOwner, string customer,int categoryId)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Fırsat adı boş olamaz!!");

            var oldOpportunity = _opportunityRepository.GetList().FirstOrDefault(x => x.Name == name);
            if (oldOpportunity != null)
                return;

            Opportunity opportunity = new Opportunity
            {
                Id = id,
                Name = name,
                Status = opportunityStatus,
                Owner = opportunityOwner,
                Customer = customer,
                CreatedDate = DateTime.Now,
                CategoryId = categoryId
            };

            _opportunityRepository.Add(opportunity);
        }

        public bool DeleteOpportunity(int opportunityId)
        {
            return _opportunityRepository.Remove(opportunityId);
        }

        public bool DeleteOppWithCategory(int categoryId)
        {
            
           var oppList = _opportunityRepository.GetList().Where(o => o.CategoryId == categoryId).ToList();

             foreach(var opp in oppList)   //başka bir yöntem
            {
                _opportunityRepository.Remove(opp.Id);
            }
            
            //foreach(var deleted in _opportunityRepository.GetList()) 
            //{
            //    if (deleted.CategoryId == categoryId) {
            //        _opportunityRepository.Remove(categoryId);
            //    }
            //}


            return true;
        }

        public IReadOnlyCollection<Opportunity> GetOpportunities()
        {
            return _opportunityRepository.GetList().ToList().AsReadOnly();
        }

        public Opportunity UpdateOpportunity(int opportunityId, string newOpportunityName, string opportunityStatus,int categoryId,string customer,string owner)
        {
            if (string.IsNullOrWhiteSpace(newOpportunityName))
                throw new ArgumentNullException("Fırsat adı boş olamaz!!");

            var opportunity = new Opportunity();
            opportunity.Customer = customer;
            opportunity.CategoryId = categoryId;
            opportunity.Id = opportunityId;
            opportunity.Name = newOpportunityName;
            opportunity.Status  = opportunityStatus;
            opportunity.UpdatedDate= DateTime.Now;
            opportunity.Owner = owner; 
            
            return _opportunityRepository.Update(opportunityId, opportunity);
        }

    }
}
