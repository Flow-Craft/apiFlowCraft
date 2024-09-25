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
    }
}
