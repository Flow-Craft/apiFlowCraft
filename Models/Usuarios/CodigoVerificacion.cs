namespace ApiNet8.Models.Usuarios
{
    public class CodigoVerificacion
    {
        public int IdCodigoVerificacion { get; set; }
        public string Codigo {  get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaExpiracion { get; set; }

        // Relaciones
        public Usuario Usuario { get; set; }
    }
}
