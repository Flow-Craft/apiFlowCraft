﻿namespace ApiNet8.Models.DTO
{
    public class TipoAccionPartidoDTO
    {
        public int Id { get; set; }
        public string? NombreTipoAccion { get; set; }
        public string?  Descripcion { get; set; }
        public bool? ModificaTarjetasAdvertencia { get; set; }
        public bool? ModificaTarjetasExpulsion { get; set; }
        public bool? secuencial { get; set; }
        public int? IdDisciplina { get; set; }
    }
}