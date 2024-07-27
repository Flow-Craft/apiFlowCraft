﻿using ApiNet8.Models.DTO;
using ApiNet8.Models.TYC;
using ApiNet8.Models.Usuarios;
using AutoMapper;

namespace ApiNet8.Utils.Mappers
{
    public class APIMappers : Profile
    {
        public APIMappers()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<TerminosYCondiciones, TerminosYCondicionesDTO>().ReverseMap();

        }
    }
}
