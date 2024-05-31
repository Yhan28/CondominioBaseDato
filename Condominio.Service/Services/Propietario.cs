using AutoMapper;
using Condominio.DataAccess.Abstract.Personas;
using Condominio.DataAccess.Abstract.Viviendas;
using Condominio.GrpcProtos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Condominio.Services.Services
{
    public class Propietario_Service : Propietario.PropietarioBase
    {

        private IPersonaRepository _PropietarioRepository;
        private IMapper _mapper;

        public Propietario_Service(IPersonaRepository repository, IMapper mapper)
        {
            _PropietarioRepository = repository;
            _mapper = mapper;
        }

        public override Task<PropietarioDTO> CreatePropietario(CreatePropietarioRequest request, ServerCallContext context)
        {
            _PropietarioRepository.BeginTransaction();
            Condominio.Domain.Entities.Viviendas.Vivienda? vivienda = ((IViviendaRepository)_PropietarioRepository).GetVivienda<Condominio.Domain.Entities.Viviendas.Vivienda>(request.Vivienda.Id);
            var propietario = _PropietarioRepository.CreatePropietario(request.Nombre, request.Ci, (int)request.Telefono, vivienda);
            _PropietarioRepository.CommitTransaction();
            return Task.FromResult(_mapper.Map<PropietarioDTO>(propietario));
        }

        public override Task<NullablePropietarioDTO> GetPropietario(GetRequest request, ServerCallContext context)
        {
            _PropietarioRepository.BeginTransaction();
            var propietario = _PropietarioRepository.GetPersona<Condominio.Domain.Entities.Propietarios.Propietario>(request.Id);
            _PropietarioRepository.CommitTransaction();

            var result = new NullablePropietarioDTO();
            if (propietario is not null)
                result.Propietario = _mapper.Map<PropietarioDTO>(propietario);

            return Task.FromResult(result);
        }

        public override Task<Empty> UpdatePropietario(PropietarioDTO request, ServerCallContext context)
        {
            var modifiedPropietario = _mapper.Map<Condominio.Domain.Entities.Propietarios.Propietario>(request);
            _PropietarioRepository.BeginTransaction();
            _PropietarioRepository.UpdatePersona(modifiedPropietario);
            _PropietarioRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

        public override Task<Empty> DeletePropietario(PropietarioDTO request, ServerCallContext context)
        {
            var propietario = _mapper.Map<Condominio.Domain.Entities.Propietarios.Propietario>(request);
            _PropietarioRepository.BeginTransaction();
            _PropietarioRepository.DeletePersona(propietario);
            _PropietarioRepository.CommitTransaction();

            return Task.FromResult(new Empty());
        }

    }
}
