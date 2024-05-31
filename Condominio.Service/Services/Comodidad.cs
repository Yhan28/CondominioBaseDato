using AutoMapper;
using Condominio.DataAccess.Abstract.Comodidades;
using Condominio.GrpcProtos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Condominio.Services.Services
{
    public class ComodidadService : Comodidad.ComodidadBase
    {

        private IComodidadesRepository _ComodidadRepository;
        private IMapper _mapper;

        public ComodidadService(IComodidadesRepository repository, IMapper mapper)
        {
            _ComodidadRepository = repository;
            _mapper = mapper;
        }

        public override Task<ComodidadDTO> CreateComodidad(CreateComodidadRequest request, ServerCallContext context)
        {
            _ComodidadRepository.BeginTransaction();
            var comodidad = _ComodidadRepository.CreateComodidad(request.Nombre, (int)request.Valor);
            _ComodidadRepository.CommitTransaction();
            return Task.FromResult(_mapper.Map<ComodidadDTO>(comodidad));
        }

        public override Task<NullableComodidadDTO> GetComodidad(GetRequest request, ServerCallContext context)
        {
            _ComodidadRepository.BeginTransaction();
            var comodidad = _ComodidadRepository.GetComodidad(request.Id);
            _ComodidadRepository.CommitTransaction();

            var result = new NullableComodidadDTO();
            if (comodidad is not null)
                result.Comodidad = _mapper.Map<ComodidadDTO>(comodidad);

            return Task.FromResult(result);
        }

        public override Task<Empty> UpdateComodidad(ComodidadDTO request, ServerCallContext context)
        {
            var modifiedComodidad = _mapper.Map<Condominio.Domain.Entities.Comodidades.Comodidad>(request);
            _ComodidadRepository.BeginTransaction();
            _ComodidadRepository.UpdateComodidad(modifiedComodidad);
            _ComodidadRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

        public override Task<Empty> DeleteComodidad(ComodidadDTO request, ServerCallContext context)
        {
            var comodidad = _mapper.Map<Condominio.Domain.Entities.Comodidades.Comodidad>(request);
            _ComodidadRepository.BeginTransaction();
            _ComodidadRepository.DeleteComodidad(comodidad);
            _ComodidadRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

    }
}
