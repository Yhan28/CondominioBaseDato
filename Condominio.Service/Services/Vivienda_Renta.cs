using AutoMapper;
using Condominio.DataAccess.Abstract.Personas;
using Condominio.DataAccess.Abstract.Viviendas;
using Condominio.GrpcProtos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Condominio.Services.Services
{
    public class Vivienda_Renta_Service : Vivienda_Renta.Vivienda_RentaBase
    {

        private IViviendaRepository _Vivienda_RentaRepository;
        private IMapper _mapper;

        public Vivienda_Renta_Service(IViviendaRepository repository, IMapper mapper)
        {
            _Vivienda_RentaRepository = repository;
            _mapper = mapper;
        }

        public override Task<Vivienda_RentaDTO> CreateVivienda_Renta(CreateVivienda_RentaRequest request, ServerCallContext context)
        {
            _Vivienda_RentaRepository.BeginTransaction();
            var vivienda_renta = _Vivienda_RentaRepository.CreateVivienda_Renta((int)request.Numeracion, (int)request.Precio, request.Direccion);
            _Vivienda_RentaRepository.CommitTransaction();
            return Task.FromResult(_mapper.Map<Vivienda_RentaDTO>(vivienda_renta));
        }

        public override Task<NullableVivienda_RentaDTO> GetVivienda_Renta(GetRequest request, ServerCallContext context)
        {
            _Vivienda_RentaRepository.BeginTransaction();
            var vivienda_renta = _Vivienda_RentaRepository.GetVivienda<Condominio.Domain.Entities.Viviendas.Vivienda_Renta>(request.Id);
            _Vivienda_RentaRepository.CommitTransaction();

            var result = new NullableVivienda_RentaDTO();
            if (vivienda_renta is not null)
                result.ViviendaRenta = _mapper.Map<Vivienda_RentaDTO>(vivienda_renta);

            return Task.FromResult(result);
        }

        public override Task<Empty> UpdateVivienda_Renta(Vivienda_RentaDTO request, ServerCallContext context)
        {
            var modifiedVivienda_Renta = _mapper.Map<Condominio.Domain.Entities.Viviendas.Vivienda_Renta>(request);
            _Vivienda_RentaRepository.BeginTransaction();
            _Vivienda_RentaRepository.UpdateVivienda(modifiedVivienda_Renta);
            _Vivienda_RentaRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

        public override Task<Empty> DeleteVivienda_Renta(Vivienda_RentaDTO request, ServerCallContext context)
        {
            var vivienda_renta = _mapper.Map<Condominio.Domain.Entities.Viviendas.Vivienda_Renta>(request);
            _Vivienda_RentaRepository.BeginTransaction();
            _Vivienda_RentaRepository.DeleteVivienda(vivienda_renta);
            _Vivienda_RentaRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

    }
}
