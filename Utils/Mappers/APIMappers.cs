using ApiNet8.Models.DTO;
using ApiNet8.Models.Eventos;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Partidos;
using ApiNet8.Models.TYC;
using ApiNet8.Models.Usuarios;
using ApiNet8.Models.NoticiasYNotificaciones;
using AutoMapper;
using ApiNet8.Models.Reservas;

namespace ApiNet8.Utils.Mappers
{
    public class APIMappers : Profile
    {
        public APIMappers()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<TerminosYCondiciones, TerminosYCondicionesDTO>().ReverseMap();
            CreateMap<Perfil, PerfilDTO>().ReverseMap();
            CreateMap<Noticias, NoticiaDTO>().ReverseMap();
            CreateMap<Instalacion, InstalacionDTO>().ReverseMap();
            CreateMap<UsuarioEstado, UsuarioEstadoDTO>().ReverseMap();
            CreateMap<EstadoEvento, EstadoEventoDTO>().ReverseMap();
            CreateMap<EquipoEstado, EquipoEstadoDTO>().ReverseMap();
            CreateMap<EquipoEstado, EquipoEstadoDTO>().ReverseMap();
            CreateMap<Disciplina, DisciplinaDTO>().ReverseMap();
            CreateMap<Disciplina, DisciplinaMenuDTO>().ReverseMap();
            CreateMap<Usuario, MiPerfilDTO>().ReverseMap();
        }
    }
}
