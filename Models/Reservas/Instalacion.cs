namespace ApiNet8.Models.Reservas
{
    public class Instalacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public float Precio { get; set; }
        public string Condiciones { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraCierre { get; set; }

        // Relaciones
        public IList<InstalacionHistorial> InstalacionHistoriales { get; set; }
    }
}
