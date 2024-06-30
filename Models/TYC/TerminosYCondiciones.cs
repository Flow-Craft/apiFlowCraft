namespace ApiNet8.Models.TYC
{
    public class TerminosYCondiciones
    {
        public int Id { get; set; }
        public string TYC { get; set; }

        // Relaciones
        public List<HistorialTerminosYCondiciones> HistorialTerminosYCondicionesList { get; set; }
    }
}
