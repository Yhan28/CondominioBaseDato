using AutoMapper;
using Condominio.DataAccess.Abstract.Viviendas;
using Condominio.GrpcProtos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Condominio.Services.Services
{
    public class ViviendaService : Vivienda.ViviendaBase
    {

        private IViviendaRepository _ViviendaRepository;
        private IMapper _mapper;

        public ViviendaService(IViviendaRepository repository, IMapper mapper)
        {
            _ViviendaRepository = repository;
            _mapper = mapper;
        }

        public override Task<ViviendaDTO> CreateVivienda(CreateViviendaRequest request, ServerCallContext context)
        { 
            _ViviendaRepository.BeginTransaction();
            var vivienda = _ViviendaRepository.CreateVivienda((int)request.Numeracion, request.Direccion);
            _ViviendaRepository.CommitTransaction();
            return Task.FromResult(_mapper.Map<ViviendaDTO>(vivienda));
        }

        public override Task<NullableViviendaDTO> GetVivienda(GetRequest request, ServerCallContext context)
        {
            _ViviendaRepository.BeginTransaction();
            var vivienda = _ViviendaRepository.GetVivienda<Condominio.Domain.Entities.Viviendas.Vivienda>(request.Id);
            _ViviendaRepository.CommitTransaction();

            var result = new NullableViviendaDTO();
            if (vivienda is not null)

                    result.Vivienda = _mapper.Map<ViviendaDTO>(vivienda);

            return Task.FromResult(result);
        }

        public override Task<Empty> UpdateVivienda(ViviendaDTO request, ServerCallContext context)
        {
            var modifiedVivienda = _mapper.Map<Condominio.Domain.Entities.Viviendas.Vivienda>(request);
            _ViviendaRepository.BeginTransaction();
            _ViviendaRepository.UpdateVivienda(modifiedVivienda);
            _ViviendaRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

        public override Task<Empty> DeleteVivienda(ViviendaDTO request, ServerCallContext context)
        {
            var vivienda = _mapper.Map<Condominio.Domain.Entities.Viviendas.Vivienda>(request);
            _ViviendaRepository.BeginTransaction();
            _ViviendaRepository.DeleteVivienda(vivienda);
            _ViviendaRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

    }
}
