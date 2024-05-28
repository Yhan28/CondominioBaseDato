using AutoMapper;
using Condominio.DataAccess.Abstract.Comodidades;
using Condominio.Grpc
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace Condominio.Service.Services
{
    public class ComodidadService : Condominio.GrpcProtos.Comodidad.ComodidadBase
    {

        private IComodidadesRepository _comodidadRepository;
        private IMapper _mapper;











    }