using AutoMapper;
using Condominio.DataAccess.Abstract.Personas;
using Condominio.DataAccess.Abstract.Viviendas;
using Condominio.GrpcProtos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Condominio.Services.Services
{
    public class Inquilino_Service : Inquilino.InquilinoBase
    {

        private IPersonaRepository _InquilinoRepository;
        private IMapper _mapper;

        public Inquilino_Service(IPersonaRepository repository, IMapper mapper)
        {
            _InquilinoRepository = repository;
            _mapper = mapper;
        }

        public override Task<InquilinoDTO> CreateInquilino(CreateInquilinoRequest request, ServerCallContext context)
        {
            _InquilinoRepository.BeginTransaction();
            Condominio.Domain.Entities.Viviendas.Vivienda? vivienda = ((IViviendaRepository)_InquilinoRepository).GetVivienda <Condominio.Domain.Entities.Viviendas.Vivienda> (request.Vivienda.Id);
            var inquilino = _InquilinoRepository.CreateInquilino(request.Nombre, request.FechaContrat, request.Ci, (int)request.Telefono, (int)request.DuracionContrat);
            _InquilinoRepository.CommitTransaction();
            return Task.FromResult(_mapper.Map<InquilinoDTO>(inquilino));
        }

        public override Task<NullableInquilinoDTO> GetInquilino(GetRequest request, ServerCallContext context)
        {
            _InquilinoRepository.BeginTransaction();
            var inquilino = _InquilinoRepository.GetPersona<Condominio.Domain.Entities.Inquilinos.Inquilino>(request.Id);
            _InquilinoRepository.CommitTransaction();

            var result = new NullableInquilinoDTO();
            if (inquilino is not null)
                result.Inquilino = _mapper.Map<InquilinoDTO>(inquilino);

            return Task.FromResult(result);
        }

        public override Task<Empty> UpdateInquilino(InquilinoDTO request, ServerCallContext context)
        {
            var modifiedInquilino = _mapper.Map<Condominio.Domain.Entities.Inquilinos.Inquilino>(request);
            _InquilinoRepository.BeginTransaction();
            _InquilinoRepository.UpdatePersona(modifiedInquilino);
            _InquilinoRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

        public override Task<Empty> DeleteInquilino(InquilinoDTO request, ServerCallContext context)
        {
            var inquilino = _mapper.Map<Condominio.Domain.Entities.Inquilinos.Inquilino>(request);
            _InquilinoRepository.BeginTransaction();
            _InquilinoRepository.DeletePersona(inquilino);
            _InquilinoRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

    }
}
