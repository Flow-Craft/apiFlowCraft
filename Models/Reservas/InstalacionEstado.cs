﻿namespace ApiNet8.Models.Reservas
{
    public class InstalacionEstado
    {
        public int Id { get; set; }
        public string DescripcionEstado { get; set; }
        public string NombreEstado { get; set; } // Activo, Inactivo, Abierta, Cerrada, CerradaMantenimiento
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}
