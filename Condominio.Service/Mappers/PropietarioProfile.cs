using AutoMapper;
using Condominio.GrpcProtos;

namespace Condominio.Services.Mappers
{
    public class PropietarioProfile : Profile
    {
        public PropietarioProfile()
        {
            CreateMap<Condominio.Domain.Entities.Propietarios.Propietario, InquilinoDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Ci, o => o.MapFrom(s => s.CI))
                .ForMember(t => t.Telefono, o => o.MapFrom(s => s.Telefono))
                .ForMember(t => t.Vivienda, o => o.MapFrom(s => s.Vivienda));

            CreateMap<PropietarioDTO, Condominio.Domain.Entities.Propietarios.Propietario>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.CI, o => o.MapFrom(s => s.Ci))
                .ForMember(t => t.Telefono, o => o.MapFrom(s => s.Telefono))
                .ForMember(t => t.Vivienda, o => o.MapFrom(s => s.Vivienda));

        }

    }
}
