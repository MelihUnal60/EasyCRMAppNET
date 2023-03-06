using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCRMAppNET.Domain.Entities;
using EasyCRMAppNET.Domain.Interfaces;
using EasyCRMAppNET.Infrastructure;
using EasyCRMAppNET.Infrastructure.IOToTXT;

namespace EasyCRMAppNET.App
{
    public class ApplicationServiceSettings
    {
        public static void RegisterAllServices()
        {
            //IOCContainer.Register<IRepository<Category>>(Method);

            IOCContainer.Register<IRepository<Category>>(() => new TextFileRepository<Category>());
            IOCContainer.Register<ICategoryService>(() => new CategoryService());
            IOCContainer.Register<IOpportunityService>(() => new OpportunityService());
            IOCContainer.Register<IRepository<Opportunity>>(() => new TextFileRepository<Opportunity>());
        }
        public static IRepository<Category> Method()
        {
            return new TextFileRepository<Category>();
        }
        public static IRepository<Opportunity> OpportunityMethod()
        {
            return new TextFileRepository<Opportunity>();
        }
    }
}