using SIP.Domain.Entities;
using System;
using System.Linq;
using SIP.Domain.Interfaces.Services;
using SIP.Domain.Interfaces.Repositories;

namespace SIP.Domain.Services
{
    public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : BaseEntity
    {
        private IRepository<T> _repository;

        public ServiceBase(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Post(T obj)
        {
            Validate(obj);

            _repository.Add(obj);
            _repository.SaveChanges();
        }

        public void Put(T obj)
        {
            Validate(obj);
            _repository.Update(obj);
            _repository.SaveChanges();
        }

        public void Delete(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Id não preenchido.");

            _repository.Remove(id);
            _repository.SaveChanges();
        }

        public IQueryable<T> Get() => _repository.GetAll();

        public T Get(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Id não preenchido.");

            return _repository.GetById(id);
        }

        private void Validate(T obj)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");
        }

        public void Dispose()
        {
            _repository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
