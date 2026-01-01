using App_RRHH.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace App_RRHH.Vistas.VistasExtras
{
    public partial class VistaPrimeraEjecucion : Form
    {
        public VistaPrimeraEjecucion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEmpleado.Text;
            string[] partes = nombre.Split(' ');

            string nombreEmpleado = partes[0];

            var config = new Configuraciones
            {
                NombreEmpleado = nombreEmpleado,
                UsuarioEmpleado = txtNombreUsuario.Text,
                CorreoAsociado = txtCorreo.Text,

                // Campos adicionales nulos
                ServidorCorreo = null,
                CuerpoCorreo = null,
                RutaOrigen = null,
                RutaDestino = null,
                PuertoCorreo = 0,
                FechaActual = DateTime.Now,

                // Configuración general
                RedimensionarColumnas = false,
                MostrarGrid = false,
                OrdenarColumnas = false,
                HoverLoad = false,
                MostrarInfo = false,

                //Configuración reportes
                BusquedaTiempoReal = false,
                ColoresEstado = false,
                FiltroDinamico = false,
                MostrarContador = false,
                ExportarAvanzado = false,
            };

            // Guardar en la carpeta de ejecución de la app
            string rutaConfig = Path.Combine(Application.StartupPath, "config.json");
            string json = JsonConvert.SerializeObject(config, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(rutaConfig, json);

            MessageBox.Show("Configuración inicial guardada correctamente.");

            // Solo cerrar con resultado OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
