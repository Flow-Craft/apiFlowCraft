﻿namespace ApiNet8.Utils
{
    public class Enums
    {

        public enum SolicitudAsociacionEstado
        {
            Aprobada = 1,
            Rechazada = 2,
            Pendiente = 3
        }

        public enum Perfiles
        {
            Simpatizante = 1,
            Socio = 2,
            Admin = 3,
            Administrativo,
            Profesor,
            Arbitro,
            Planillero
        }

        public enum LeccionEstado
        {
            Vigente = 1,
            ClaseIniciada = 2,
            Terminada = 3,
            Eliminada = 4
        }

        public enum EstadoEvento
        {
            Creado = 1,
            Cancelado = 2,
            Finalizado = 3,
            Iniciado = 4,
            Suspendido = 5,
            Entretiempo = 6
        }

        public enum EstadoInstalacion
        {
            Activo = 1,
            Inactivo = 2,
            Abierta = 3,
            CerradaReparacion = 4,
            CerradaRemodelacion = 5
        }

        public enum EstadoUsuario
        {
            Activo = 1,
            Bloqueado = 2,
            Desactivado = 3
        }

        public enum EstadoEquipo
        {
            Activo = 1,
            Inactivo = 2,
            Suspendido = 3
        }

        public enum TipoEvento
        {
            Partido = 1,
            Torneo = 2,
            Recital = 3,
            Taller = 4,
            Curso = 5,
            Feria = 6
        }

        public enum Disciplinas
        {
            Futbol= 1,
            Voleyball = 2,              
        }

        public enum EstadoTorneo
        {
            Abierto = 1,
            Finalizado = 2,
            EnCurso = 3,
            Cancelado = 4,
            Completado = 5,
        }

    }
}
