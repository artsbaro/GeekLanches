using SIP.Domain.Entities;
using System;
using System.Linq;

namespace SIP.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : BaseEntity
    {
        void Post(T obj);

        void Put(T obj);

        void Delete(Guid id);

        T Get(Guid id);

        IQueryable<T> Get();
    }
}
