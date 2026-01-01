using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_RRHH.Models
{
    namespace Envio_Correos_Masivos.Models
    {
        public class Empleado
        {
            public int IdEmpleado { get; set; }
            public string NombreCompleto { get; set; }

            public int? Edad { get; set; }
            public DateTime? FechaNacimiento { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public string Correo { get; set; }
            public string JefeDirecto { get; set; }
            public string Area { get; set; }
            public string Cargo { get; set; }
            public string TelefonoEmergencia { get; set; }
            public decimal? Remuneracion { get; set; }
            public string TipoContrato { get; set; }
            public DateTime? FechaIngreso { get; set; }
            public DateTime? FechaTermino { get; set; }
            public DateTime? FechaCese { get; set; }
            public string TiempoTrabajado { get; set; }
        }
    }

}
