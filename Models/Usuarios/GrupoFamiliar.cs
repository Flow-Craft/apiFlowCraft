﻿namespace ApiNet8.Models.Usuarios
{
    public class GrupoFamiliar
    {
        public int Id { get; set; }
        public string NombreGrupoFamiliar { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int duenioGrupoFamiliar { get; set; }
        public string? Observacion { get; set; }
        public List<byte[]> DocumentosGrupoFamiliar { get; set; } = new List<byte[]>();

        // Relaciones
        public Usuario DuenioGrupoFamiliar { get; set;}
        public IList<Usuario> Integrantes {  get; set; }
    }
}
