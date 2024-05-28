using AutoMapper;
using Condominio.Domain.Entities.Personas.Inquilino;

namespace Condominio.Services.Mappers
{
    public class InquilinoProfile : Profile
    {
        public InquilinoProfile()
        {
            CreateMap<Condominio.Domain.Entities.Personas.Inquilino, InquilinoDTO>()
                .ForMember(t => t.id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.ci, o => o.MapFrom(s => s.CI))
                .ForMember(t => t.telefono, o => o.MapFrom(s => s.Telefono))
                .ForMember(t => t.vivienda, o => o.MapFrom(s => s.Vivienda))
                .ForMember(t => t.fecha_Contrat, o => o.MapFrom(s => s.Fecha_Contrat))
                .ForMember(t => t.duracion_Contrat, o => o.MapFrom(s => s.Duracion_Contrat));

            CreateMap<InquilinoDTO, Condominio.Domain.Entities.Personas.Inquilino
                >()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.id))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.nombre))
                .ForMember(t => t.CI, o => o.MapFrom(s => s.valor))
                .ForMember(t => t.Telefono, o => o.MapFrom(s => s.telefono))
                .ForMember(t => t.Vivienda, o => o.MapFrom(s => s.vivienda))
                .ForMember(t => t.Fecha_Contrat, o => o.MapFrom(s => s.fecha_Contrat))
                .ForMember(t => t.Duracion_Contrat, o => o.MapFrom(s => s.duracion_Contrat));

        }

    }
}
