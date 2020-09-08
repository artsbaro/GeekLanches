using SIP.Domain.Entities;
using SIP.Domain.Interfaces.Repositories;
using SIP.Domain.Interfaces.Services;


namespace SIP.Domain.Services
{
    public class MunicipioNascimentoService : ServiceBase<MunicipioNascimento>, IMunicipioNascimentoService
    {
        private readonly IMunicipioNascimentoRepository _repository;
        public MunicipioNascimentoService(IMunicipioNascimentoRepository repository) 
            : base(repository)
        {
            _repository = repository;
        }
    }
}