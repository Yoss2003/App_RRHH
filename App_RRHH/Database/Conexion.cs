using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace App_RRHH.Conexion
{
    public class Conexion
    {
        private static readonly string rutaBD = Path.Combine(Application.StartupPath, "BMP.db");
        private static readonly string cadena = $"Data Source={rutaBD}; Version=3;";

        public static SQLiteConnection ObtenerConexion()
        {
            return new SQLiteConnection(cadena);
        }

        public static void InicializarBD()
        {
            if (!File.Exists(rutaBD))
            {
                SQLiteConnection.CreateFile(rutaBD);
            }

            using (var conn = ObtenerConexion())
            {
                conn.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Empleados(
                    IdEmpleado INTEGER PRIMARY KEY AUTOINCREMENT, 
                    NombreCompleto NVARCHAR(150) NOT NULL, 
                    Edad INT NULL, 
                    FechaNacimiento DATE NULL, 
                    Telefono NVARCHAR(20) NULL, 
                    Direccion NVARCHAR(200) NULL, 
                    Correo NVARCHAR(100) NULL, 
                    JefeDirecto NVARCHAR(100) NULL, 
                    Area NVARCHAR(100) NULL, 
                    Cargo NVARCHAR(100) NULL, 
                    TelefonoEmergencia NVARCHAR(20) NULL, 
                    Remuneracion DECIMAL(10,2) NULL, 
                    TipoContrato NVARCHAR(50) NULL, 
                    FechaIngreso DATE NULL, 
                    FechaTermino DATE NULL,
                    FechaCese DATE NULL, 
                    TiempoTrabajado NVARCHAR(50) NULL
                    );";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
