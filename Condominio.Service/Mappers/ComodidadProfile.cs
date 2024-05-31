using AutoMapper;
using Condominio.GrpcProtos;

namespace Condominio.Services.Mappers
{
    public class ComodidadProfile : Profile
    {
        public ComodidadProfile()
        {
            CreateMap<Condominio.Domain.Entities.Comodidades.Comodidad, ComodidadDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Valor, o => o.MapFrom(s => s.Valor));

            CreateMap<ComodidadDTO, Condominio.Domain.Entities.Comodidades.Comodidad>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Valor, o => o.MapFrom(s => s.Valor));

        }

    }
}
