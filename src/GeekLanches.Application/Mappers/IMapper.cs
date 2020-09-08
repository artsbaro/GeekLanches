using System.Collections.Generic;

namespace GeekLanches.Application.Mappers
{
    public interface IMapper<MapFrom, MapTo>
    {
        MapTo Map(MapFrom source);

        IEnumerable<MapTo> Map(IEnumerable<MapFrom> source);
    }
}
