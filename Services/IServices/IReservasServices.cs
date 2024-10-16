﻿using ApiNet8.Models.Eventos;
using ApiNet8.Models.Reservas;

namespace ApiNet8.Services.IServices
{
    public interface IReservasServices
    {
        public bool VerificarInstalacionDisponible(DateTime fechaInicio, DateTime fechaFin, Instalacion instalacion, Evento evento);
        List<Reserva> GetReservasByInstalacion(Instalacion instalacion);
        List<Reserva> GetReservas();
        public List<Reserva> GetReservasByEvento(Evento evento);
    }
}
