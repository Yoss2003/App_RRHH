using App_RRHH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_RRHH.Vistas.VistasPrincipales
{
    public partial class VistaConvertirPDF : Form
    {
        Configuraciones config;

        public VistaConvertirPDF()
        {
            InitializeComponent();
        }

        private void AjustarColumnas(ListView listView)
        {
            int anchoTotal = listView.ClientSize.Width;
            int columnas = listView.Columns.Count;

            if (columnas == 0) return;

            foreach (ColumnHeader columna in listView.Columns)
            {
                columna.Width = anchoTotal / columnas;
            }
        }

        private void CargarArchivos()
        {
            var rutas = ObtenerRutasMes();
            string rutaOrigenCompleta = rutas.rutaOrigenCompleta;
            string rutaDestinoCompleta = rutas.rutaDestinoCompleta;

            // Archivos Word
            listViewOrigen.Items.Clear();
            if (Directory.Exists(rutaOrigenCompleta))
            {
                string[] archivosWord = Directory.GetFiles(rutaOrigenCompleta, "*.docx");
                foreach (string archivo in archivosWord)
                {
                    string nombre = Path.GetFileName(archivo);
                    string fecha = File.GetLastWriteTime(archivo).ToString("dd/MM/yyyy HH:mm");

                    // calcular tamaño
                    long bytes = new FileInfo(archivo).Length;
                    string tamaño = FormatearTamaño(bytes);

                    ListViewItem item = new ListViewItem(nombre);
                    item.SubItems.Add(fecha);
                    item.SubItems.Add(tamaño); // 👈 aquí agregas el tamaño
                    listViewOrigen.Items.Add(item);
                }
            }

            // Archivos PDF
            listViewDestino.Items.Clear();
            if (Directory.Exists(rutaDestinoCompleta))
            {
                string[] archivosPdf = Directory.GetFiles(rutaDestinoCompleta, "*.pdf");
                foreach (string archivo in archivosPdf)
                {
                    string nombre = Path.GetFileName(archivo);
                    string fecha = File.GetLastWriteTime(archivo).ToString("dd/MM/yyyy HH:mm");

                    // calcular tamaño
                    long bytes = new FileInfo(archivo).Length;
                    string tamaño = FormatearTamaño(bytes);

                    ListViewItem item = new ListViewItem(nombre);
                    item.SubItems.Add(fecha);
                    item.SubItems.Add(tamaño); // 👈 aquí agregas el tamaño
                    listViewDestino.Items.Add(item);
                }
            }
        }

        // Función auxiliar para mostrar KB o MB
        private string FormatearTamaño(long bytes)
        {
            if (bytes >= 1024 * 1024)
                return $"{bytes / (1024 * 1024.0):0.##} MB";
            else
                return $"{bytes / 1024.0:0.##} KB";
        }

        private (string rutaOrigenCompleta, string rutaDestinoCompleta) ObtenerRutasMes()
        {
            string rutaOrigen = config.RutaOrigen;
            string rutaDestino = config.RutaDestino;

            int año = DateTime.Now.Year;
            int mesNumero = DateTime.Now.Month;
            string mesNombre = DateTime.Now.ToString("MMMM", new System.Globalization.CultureInfo("es-ES")).ToUpper();
            string carpetaMes = $"{mesNumero:D2}.{mesNombre}";

            string rutaOrigenCompleta = Path.Combine(rutaOrigen, año.ToString(), carpetaMes);
            string rutaDestinoCompleta = Path.Combine(rutaDestino, año.ToString(), carpetaMes);

            return (rutaOrigenCompleta, rutaDestinoCompleta);
        }

        private void btnBorrarPDF_Click(object sender, EventArgs e)
        {
            var rutas = ObtenerRutasMes();
            string rutaDestinoCompleta = rutas.rutaDestinoCompleta;

            // Lista de archivos seleccionados
            List<string> seleccionados = new List<string>();
            foreach (ListViewItem item in listViewDestino.Items)
            {
                if (item.Checked)
                {
                    string nombreArchivo = item.Text;
                    string rutaCompleta = Path.Combine(rutaDestinoCompleta, nombreArchivo);
                    seleccionados.Add(rutaCompleta);
                }
            }

            if (seleccionados.Count == 0)
            {
                MessageBox.Show("No se seleccionó ningún archivo para borrar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirmación
            DialogResult respuesta = MessageBox.Show(
                $"¿Desea eliminar {seleccionados.Count} archivo(s) PDF seleccionado(s)?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                foreach (string archivo in seleccionados)
                {
                    try
                    {
                        if (File.Exists(archivo))
                        {
                            File.Delete(archivo);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar {Path.GetFileName(archivo)}: {ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Archivos eliminados correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar la lista
                CargarArchivos();
            }
        }

        private void VistaConvertirPDF_Load(object sender, EventArgs e)
        {
            lblRutaOrigen.Left = (groupBoxOrigen.Width - lblRutaOrigen.Width) / 2;
            lblRutaDestino.Left = (groupBoxDestino.Width - lblRutaDestino.Width) / 2;

            AjustarColumnas(listViewOrigen); 
            AjustarColumnas(listViewDestino);
        }

        private void lblRutaOrigen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rutas = ObtenerRutasMes(); 
            string rutaOrigenCompleta = rutas.rutaOrigenCompleta; 
            if (Directory.Exists(rutaOrigenCompleta)) 
            { 
                Process.Start("explorer.exe", rutaOrigenCompleta); 
            } 
            else 
            { 
                MessageBox.Show("La carpeta de origen no existe."); 
            }
        }

        private void lblRutaDestino_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rutas = ObtenerRutasMes();
            string rutaDestinoCompleta = rutas.rutaDestinoCompleta;
            if (Directory.Exists(rutaDestinoCompleta))
            {
                Process.Start("explorer.exe", rutaDestinoCompleta);
            }
            else
            {
                MessageBox.Show("La carpeta de origen no existe.");
            }
        }
    }
}
