namespace ApiNet8.Models.DTO
{
    public class AsistenciaLeccionDTO
    {
        public int Id { get; set; }
        public List<int> AlumnosAsist { get; set; }
        public int IdLeccion { get; set; }
    }
}
