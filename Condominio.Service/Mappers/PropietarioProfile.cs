using AutoMapper;
using Condominio.Domain.Entities.Personas.Propietario;

namespace Condominio.Services.Mappers
{
    public class Vivienda_RentaProfile : Profile
    {
        public Vivienda_RentaProfile()
        {
            CreateMap<Condominio.Domain.Entities.Personas.Propietario, InquilinoDTO>()
                .ForMember(t => t.id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.ci, o => o.MapFrom(s => s.CI))
                .ForMember(t => t.telefono, o => o.MapFrom(s => s.Telefono))
                .ForMember(t => t.vivienda, o => o.MapFrom(s => s.Vivienda));

            CreateMap<PropietarioDTO, Condominio.Domain.Entities.Personas.Propietario>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.id))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.nombre))
                .ForMember(t => t.CI, o => o.MapFrom(s => s.valor))
                .ForMember(t => t.Telefono, o => o.MapFrom(s => s.telefono))
                .ForMember(t => t.Vivienda, o => o.MapFrom(s => s.vivienda));

        }

    }
}
