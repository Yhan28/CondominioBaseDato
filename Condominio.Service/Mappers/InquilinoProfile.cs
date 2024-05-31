using AutoMapper;
using Condominio.GrpcProtos;

namespace Condominio.Services.Mappers
{
    public class InquilinoProfile : Profile
    {
        public InquilinoProfile()
        {
            CreateMap<Condominio.Domain.Entities.Inquilinos.Inquilino, InquilinoDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Ci, o => o.MapFrom(s => s.CI))
                .ForMember(t => t.Telefono, o => o.MapFrom(s => s.Telefono))
                .ForMember(t => t.Vivienda, o => o.MapFrom(s => s.Vivienda))
                .ForMember(t => t.FechaContrat, o => o.MapFrom(s => s.Fecha_Contrat))
                .ForMember(t => t.DuracionContrat, o => o.MapFrom(s => s.Duracion_Contrat));

            CreateMap<InquilinoDTO, Condominio.Domain.Entities.Inquilinos.Inquilino
                >()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.CI, o => o.MapFrom(s => s.Ci))
                .ForMember(t => t.Telefono, o => o.MapFrom(s => s.Telefono))
                .ForMember(t => t.Vivienda, o => o.MapFrom(s => s.Vivienda))
                .ForMember(t => t.Fecha_Contrat, o => o.MapFrom(s => s.FechaContrat))
                .ForMember(t => t.Duracion_Contrat, o => o.MapFrom(s => s.DuracionContrat));

        }

    }
}
