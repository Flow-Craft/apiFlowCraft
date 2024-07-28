using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.Usuarios;
using AutoMapper;

namespace ApiNet8.Utils.Mappers
{
    public class APIMappers : Profile
    {
        public APIMappers()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<UsuarioEstado, UsuarioEstadoDTO>().ReverseMap();
            CreateMap<EstadoEvento, EstadoEventoDTO>().ReverseMap();
            CreateMap<EquipoEstado, EquipoEstadoDTO>().ReverseMap();
        }
    }
}
