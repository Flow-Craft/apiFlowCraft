﻿namespace ApiNet8.Models.DTO
{
    public class AccionPartidoDTO
    {
        public int Id { get; set; }
        public int IdPartido { get; set; }
        public int IdTipoAccion { get; set; }
        public int IdJugador { get; set; }
        public int IdJugadorEnBanca { get; set; }
        public bool TotalTarjetas { get; set; }
        public bool EquipoLocal { get; set; }
        public int Minuto { get; set; }

    }
}