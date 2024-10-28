namespace ApiNet8.Models.DTO
{
    public class ReporteEstadisticaDTO
    {
        // voley
        public string Accion {  get; set; }
        public int Bien { get; set; }
        public int PorcentajeBien { get; set; }
        public int Regular {  get; set; }
        public int PorcentajeRegular { get; set; }
        public int Mal {  get; set; }
        public int PorcentajeMal { get; set; }
        public int Total { get; set; }

        // futbol
        public string Partido { get; set; }
        public int PasesCorrectos {  get; set; }
        public int PasesIncorrectos { get; set; }
        public int Goles {  get; set; }
        public int RematesAPuerta { get; set; }
        public int RematesAfuera { get; set; }
        public int Asistencias { get; set; }
        public int Amarillas { get; set; }
        public int Rojas { get; set; }
        public int RematesAtajados { get; set; }
        public int GolesRecibidos { get; set; }
        public int Faltas { get; set; }
    }
}
