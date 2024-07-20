using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;
using AutoMapper;

namespace ApiNet8.Mappers
{
    public class APIMappers : Profile
    {
        public APIMappers()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        }
    }
}
