﻿using ApiNet8.Models.Eventos;
using ApiNet8.Models.Lecciones;
using ApiNet8.Models.Reservas;

namespace ApiNet8.Models.DTO
{
    public class EventoDTO
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinEvento { get; set; }
        public byte[]? Banner { get; set; }
        public string? ImageType { get; set; } // Para almacenar el tipo de la imagen (image/jpeg, image/png)
        public int CupoMaximo { get; set; }
        public bool EventoLleno { get; set; }
        public string? LinkStream { get; set; }
        public string? Descripcion { get; set; }
        public int IdTipoEvento { get; set; }
        public int IdInstalacion { get; set; }
        public int IdCategoria { get; set; }
        public int IdDisciplina { get; set; }  
        public int? EquipoLocal {  get; set; }
        public int? EquipoVisitante { get; set; }
        public int Arbitro {  get; set; }
        public int Planillero { get; set; }
    }
}
