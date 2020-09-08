using GeekLanches.Domain.Entities;

namespace GeekLanches.Domain.Interfaces.Repositories
{
    public interface IIngredienteRepository : IRepository<Ingrediente, string>
    {
        void AplicaInflacao(decimal percentual);
    }
}
