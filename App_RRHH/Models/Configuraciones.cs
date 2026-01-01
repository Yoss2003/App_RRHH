using System;

namespace App_RRHH.Models
{
    public class Configuraciones
    {
        //Configuración general
        public bool RedimensionarColumnas { get; set; }
        public bool MostrarGrid { get; set; }
        public bool OrdenarColumnas { get; set; }
        public bool HoverLoad { get; set; }
        public bool MostrarInfo { get; set; }

        //Configuración inicio
        public string NombreEmpleado { get; set; }
        public string UsuarioEmpleado { get; set; }
        public string CorreoAsociado { get; set; }
        public string ServidorCorreo { get; set; }
        public string CuerpoCorreo { get; set; }
        public string RutaOrigen { get; set; }
        public string RutaDestino { get; set; }
        public int PuertoCorreo { get; set; }
        public DateTime FechaActual { get; set; }

        //Configuración reportes
        public bool BusquedaTiempoReal { get; set; }
        public bool ColoresEstado { get; set; }
        public bool FiltroDinamico { get; set; }
        public bool MostrarContador { get; set; }
        public bool ExportarAvanzado { get; set; }
    }
}
