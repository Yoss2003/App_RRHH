using App_RRHH.Models;
using App_RRHH.Vistas.VistasConfiguraciones;
using App_RRHH.Vistas.VistasExtras;
using App_RRHH.Vistas.VistasPrincipales;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

using ConexionClase = App_RRHH.Conexion.Conexion;

namespace App_RRHH
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void CentrarElementos(Control control, Control contenedor)
        {
            control.Location = new System.Drawing.Point(
                (contenedor.ClientSize.Width - control.Size.Width) / 2,
                control.Location.Y
            );
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            ConexionClase.InicializarBD();
            Configuraciones config;
            string rutaConfig = Path.Combine(Application.StartupPath, "config.json");

            if (!File.Exists(rutaConfig))
            {
                var primeraEjecucion = new VistaPrimeraEjecucion();
                if (primeraEjecucion.ShowDialog() != DialogResult.OK)
                    return; // si cancela, no seguimos
            }

            // Ya si existe config.json se cargar
            string json = File.ReadAllText(rutaConfig);
            config = JsonConvert.DeserializeObject<Configuraciones>(json);

            // Aplicar valores a controles del menú principal
            lblPresentacion.Text = $"Hola, {config.NombreEmpleado}";
            lblNombreEmpleado.Text = config.NombreEmpleado;
            lblUsuario.Text = config.UsuarioEmpleado;
            lblCorreoAsociado.Text = config.CorreoAsociado;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


            // Iniciar conexion a la base de datos
            try
            {
                ConexionClase.InicializarBD();
                using (var conn = ConexionClase.ObtenerConexion())
                {
                    conn.Open();
                    lblConexion.Text = "Conexion exitosa a la BD";
                    lblConexion.ForeColor = Color.Green;
                }
            }
            catch(Exception ex)
            {
                lblConexion.Text = "Error de conexión: " + ex.Message;
                lblConexion.ForeColor = Color.Red;
            }

            // Centrar el elementos del grupo Presentación
            CentrarElementos(lblPresentacion, groupPresentacion);

            // Centrar el elementos del grupo Actividades
            CentrarElementos(btnEnviarDocumentos, groupActividades);

            CentrarElementos(btnReportes, groupActividades);

            CentrarElementos(btnGenerarDocumentos, groupActividades);

            CentrarElementos(btnConvertirPDF, groupActividades);

            CentrarElementos(btnConfiguracion, groupActividades);

            CentrarElementos(lblConexion, groupActividades);

            // Centrar el elementos del grupo Información

            CentrarElementos(lblDerechos, groupInformacion);
        }

        private void btnEnviarDocumentos_Click(object sender, EventArgs e)
        {
            VistaEnviarDocumentos enviarDocumentos = new VistaEnviarDocumentos();
            enviarDocumentos.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            VistaReporte reporte = new VistaReporte();
            reporte.ShowDialog();
        }

        private void btnGenerarDocumentos_Click(object sender, EventArgs e)
        {
            VistaGenerarDocumento generarDocumento = new VistaGenerarDocumento();
            generarDocumento.ShowDialog();
        }

        private void btnConvertirPDF_Click(object sender, EventArgs e)
        {
            VistaConvertirPDF convertirPDF = new VistaConvertirPDF();
            convertirPDF.ShowDialog();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            VistaConfiguracionPrincipal configuracionPrincipal = new VistaConfiguracionPrincipal();
            configuracionPrincipal.ShowDialog();
        }
    }
}
