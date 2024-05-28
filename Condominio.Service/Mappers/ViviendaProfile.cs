using AutoMapper;

namespace Condominio.Services.Mappers
{
    public class ViviendaProfile : Profile
    {
        public ViviendaProfile()
        {

            CreateMap<Condominio.Domain.Entities.Viviendas.Vivienda, ViviendaDTO>()
                .ForMember(t => t.id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.numeracion, o => o.MapFrom(s => s.Numeracion))
                .ForMember(t => t.direccion, o => o.MapFrom(s => s.Direccion));

            CreateMap<ViviendaDTO, Condominio.Domain.Entities.Viviendas.Vivienda>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.id))
                .ForMember(t => t.Numeracion, o => o.MapFrom(s => s.numeracion))
                .ForMember(t => t.Direccion, o => o.MapFrom(s => s.direccion));
        }

    }
}
