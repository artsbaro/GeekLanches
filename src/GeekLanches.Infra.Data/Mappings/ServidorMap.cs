using Dapper.FluentMap.Dommel.Mapping;
using SIP.Domain.Entities;

namespace SIP.Infra.Data.Mappings
{
    class ServidorMap : DommelEntityMap<Servidor>
    {
        public ServidorMap()
        {
            ToTable("Servidor");
            Map(p => p.Id).IsKey();
        }
    }
}
