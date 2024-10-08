﻿using ApiNet8.Models.Usuarios;

namespace ApiNet8.Models.DTO
{
    public class UsuarioLoginResponseDTO
    {
        public string? JwtToken { get; set; }
        public UsuarioDTO? Usuario { get; set; }
        public bool EsError { get; set; }
        public string? MensajeError { get; set; }
        public string? Perfil { get; set; }
        public List<Permiso>? Permisos { get; set; }
    }
}
