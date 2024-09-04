﻿using ApiNet8.Models.DTO;
using ApiNet8.Models.Usuarios;

namespace ApiNet8.Services.IServices
{
    public interface IUsuarioServices
    {
        List<Usuario> GetUsuarios();
        Usuario? GetUsuarioById(int id);
        void CrearUsuario(UsuarioDTO usuario);
        void ActualizarUsuario(UsuarioDTO usuario);
        void EliminarUsuario(int id);
        bool ExisteUsuario(UsuarioRegistroDTO usuario);
        Task<UsuarioLoginResponseDTO> Login(UsuarioLoginDTO usuarioLoginDTO);
        Task<Usuario> Registro(UsuarioRegistroDTO usuarioRegistroDTO);
        Task<Usuario> GetUsuarioByEmailAndPassword(string email, string password);
        void Asociarse(Usuario usuario);
        MiPerfilDTO GetMiPerfil();
        void EditarMiPerfil(MiPerfilDTO miPerfilDTO);
        bool MostrarBotonAsociarse(Usuario usuario);
        void CambiarContrasena(string contrasena);
        Usuario? ExisteUsuarioActivobyEmail(string email);
        Task<bool> ReestablecerContrasenaInit(string mail);
        bool VerificarCodigo(VerificarCodigoDTO verificarCodigoDTO);
        public void ReestablecerContrasena(ReestablecerContrasenaDTO reestablecerContrasenaDTO);
        void BloquearUsuario(BloquearUsuarioDTO bloquearUsuarioDTO);
        void DesbloquearUsuario(BloquearUsuarioDTO bloquearUsuarioDTO);
    }
}
