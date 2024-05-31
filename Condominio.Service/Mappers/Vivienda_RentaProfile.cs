using AutoMapper;

namespace Condominio.Services.Mappers
{
    public class Vivienda_Renta_Profile : Profile
    {
        public Vivienda_Renta_Profile()
        {
            
            CreateMap<Condominio.Domain.Entities.Viviendas.Vivienda_Renta, Vivienda_RentaDTO>()
                .ForMember(t => t.id, o => o.MapFrom(s => s.Id))
                .ForMember(t => t.precio, o => o.MapFrom(s => s.Precio))
                .ForMember(t => t.numeracion, o => o.MapFrom(s => s.Numeracion))
                .ForMember(t => t.direccion, o => o.MapFrom(s => s.Direccion));

            CreateMap<Vivienda_RentaDTO, Condominio.Domain.Entities.Viviendas.Vivienda_Renta>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.id))
                .ForMember(t => t.Precio, o => o.MapFrom(s => s.precio))
                .ForMember(t => t.Numeracion, o => o.MapFrom(s => s.numeracion))
                .ForMember(t => t.Direccion, o => o.MapFrom(s => s.direccion));
        }

    }
}
