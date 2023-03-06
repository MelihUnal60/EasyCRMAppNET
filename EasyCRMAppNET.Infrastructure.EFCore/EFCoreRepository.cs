using EasyCRMAppNET.Domain.Entities;
using EasyCRMAppNET.Domain.Entities.Base;
using EasyCRMAppNET.Domain.Interfaces;

namespace EasyCRMAppNET.Infrastructure.EFCore
{
    public class EFCoreRepository<T> : IRepository<T> where T : BaseEntity
    {
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetList(Func<T, bool> expression = null)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}