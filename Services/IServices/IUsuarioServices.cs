﻿using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IUsuarioServices
    {
        List<Usuario> GetUsuarios();
        Usuario? GetUsuarioById(int id);
        void CrearUsuario(UsuarioDTO usuario);
        Usuario ActualizarUsuario(UsuarioDTO usuario);
        Usuario EliminarUsuario(int id);
        bool ExisteUsuario(UsuarioRegistroDTO usuario);
        Task<UsuarioLoginResponseDTO> Login(UsuarioLoginDTO usuarioLoginDTO);
        Task<Usuario> Registro(UsuarioRegistroDTO usuarioRegistroDTO);
        Task<Usuario> GetUsuarioByEmailAndPassword(string email, string password);
    }
}
