using AutoMapper;
using Condominio.GrpcProtos;

namespace Condominio.Services.Mappers
{
    public class Vivienda_Renta_Profile : Profile
    {
        public Vivienda_Renta_Profile()
        {
            
            CreateMap<Condominio.Domain.Entities.Viviendas.Vivienda_Renta, Vivienda_RentaDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.Precio, o => o.MapFrom(s => s.Precio))
                .ForMember(t => t.Numeracion, o => o.MapFrom(s => s.Numeracion))
                .ForMember(t => t.Direccion, o => o.MapFrom(s => s.Direccion));

            CreateMap<Vivienda_RentaDTO, Condominio.Domain.Entities.Viviendas.Vivienda_Renta>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.Precio, o => o.MapFrom(s => s.Precio))
                .ForMember(t => t.Numeracion, o => o.MapFrom(s => s.Numeracion))
                .ForMember(t => t.Direccion, o => o.MapFrom(s => s.Direccion));
        }

    }
}
