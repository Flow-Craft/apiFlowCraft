namespace ApiNet8.Models.Eventos
{
    public class TipoEvento
    {
        public int IdTipoEvento { get; set; }
        public string NombreTipoEvento { get; set; } // Partido, Recital, Taller, Curso, Feria
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int UsuarioEditor { get; set; }
    }
}
