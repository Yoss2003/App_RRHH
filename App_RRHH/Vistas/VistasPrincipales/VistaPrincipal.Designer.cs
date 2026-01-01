namespace App_RRHH
{
    partial class VistaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupPresentacion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.groupActividades = new System.Windows.Forms.GroupBox();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnConvertirPDF = new System.Windows.Forms.Button();
            this.btnGenerarDocumentos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnEnviarDocumentos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.groupInformacion = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCorreoAsociado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDerechos = new System.Windows.Forms.LinkLabel();
            this.groupPresentacion.SuspendLayout();
            this.groupActividades.SuspendLayout();
            this.groupInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPresentacion
            // 
            this.groupPresentacion.Controls.Add(this.label2);
            this.groupPresentacion.Controls.Add(this.lblPresentacion);
            this.groupPresentacion.Location = new System.Drawing.Point(12, 12);
            this.groupPresentacion.Name = "groupPresentacion";
            this.groupPresentacion.Size = new System.Drawing.Size(476, 100);
            this.groupPresentacion.TabIndex = 0;
            this.groupPresentacion.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "En que te puedo ayudar el día de hoy?";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblPresentacion.Location = new System.Drawing.Point(181, 19);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(106, 30);
            this.lblPresentacion.TabIndex = 0;
            this.lblPresentacion.Text = "\"NAME\"";
            // 
            // groupActividades
            // 
            this.groupActividades.Controls.Add(this.btnConfiguracion);
            this.groupActividades.Controls.Add(this.btnConvertirPDF);
            this.groupActividades.Controls.Add(this.btnGenerarDocumentos);
            this.groupActividades.Controls.Add(this.btnReportes);
            this.groupActividades.Controls.Add(this.btnEnviarDocumentos);
            this.groupActividades.Controls.Add(this.label3);
            this.groupActividades.Controls.Add(this.lblConexion);
            this.groupActividades.Location = new System.Drawing.Point(12, 118);
            this.groupActividades.Name = "groupActividades";
            this.groupActividades.Size = new System.Drawing.Size(476, 274);
            this.groupActividades.TabIndex = 0;
            this.groupActividades.TabStop = false;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnConfiguracion.Location = new System.Drawing.Point(150, 211);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(191, 31);
            this.btnConfiguracion.TabIndex = 1;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnConvertirPDF
            // 
            this.btnConvertirPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnConvertirPDF.Location = new System.Drawing.Point(150, 171);
            this.btnConvertirPDF.Name = "btnConvertirPDF";
            this.btnConvertirPDF.Size = new System.Drawing.Size(191, 31);
            this.btnConvertirPDF.TabIndex = 1;
            this.btnConvertirPDF.Text = "Convertir a PDF";
            this.btnConvertirPDF.UseVisualStyleBackColor = true;
            this.btnConvertirPDF.Click += new System.EventHandler(this.btnConvertirPDF_Click);
            // 
            // btnGenerarDocumentos
            // 
            this.btnGenerarDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnGenerarDocumentos.Location = new System.Drawing.Point(150, 131);
            this.btnGenerarDocumentos.Name = "btnGenerarDocumentos";
            this.btnGenerarDocumentos.Size = new System.Drawing.Size(191, 31);
            this.btnGenerarDocumentos.TabIndex = 1;
            this.btnGenerarDocumentos.Text = "Generar Documento";
            this.btnGenerarDocumentos.UseVisualStyleBackColor = true;
            this.btnGenerarDocumentos.Click += new System.EventHandler(this.btnGenerarDocumentos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnReportes.Location = new System.Drawing.Point(150, 91);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(191, 31);
            this.btnReportes.TabIndex = 1;
            this.btnReportes.Text = "Reporte Empleados";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnEnviarDocumentos
            // 
            this.btnEnviarDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnEnviarDocumentos.Location = new System.Drawing.Point(150, 51);
            this.btnEnviarDocumentos.Name = "btnEnviarDocumentos";
            this.btnEnviarDocumentos.Size = new System.Drawing.Size(191, 31);
            this.btnEnviarDocumentos.TabIndex = 1;
            this.btnEnviarDocumentos.Text = "Enviar Documentos";
            this.btnEnviarDocumentos.UseVisualStyleBackColor = true;
            this.btnEnviarDocumentos.Click += new System.EventHandler(this.btnEnviarDocumentos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "ACTIVIDADES";
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Location = new System.Drawing.Point(233, 253);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(15, 13);
            this.lblConexion.TabIndex = 1;
            this.lblConexion.Text = "**";
            // 
            // groupInformacion
            // 
            this.groupInformacion.Controls.Add(this.lblFecha);
            this.groupInformacion.Controls.Add(this.label10);
            this.groupInformacion.Controls.Add(this.lblNombreEmpleado);
            this.groupInformacion.Controls.Add(this.label8);
            this.groupInformacion.Controls.Add(this.lblUsuario);
            this.groupInformacion.Controls.Add(this.lblCorreoAsociado);
            this.groupInformacion.Controls.Add(this.label5);
            this.groupInformacion.Controls.Add(this.label4);
            this.groupInformacion.Controls.Add(this.lblDerechos);
            this.groupInformacion.Location = new System.Drawing.Point(12, 398);
            this.groupInformacion.Name = "groupInformacion";
            this.groupInformacion.Size = new System.Drawing.Size(476, 100);
            this.groupInformacion.TabIndex = 0;
            this.groupInformacion.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(390, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(15, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "**";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fecha:";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(390, 26);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(15, 13);
            this.lblNombreEmpleado.TabIndex = 6;
            this.lblNombreEmpleado.Text = "**";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Empleado:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(99, 53);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(15, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "**";
            // 
            // lblCorreoAsociado
            // 
            this.lblCorreoAsociado.AutoSize = true;
            this.lblCorreoAsociado.Location = new System.Drawing.Point(99, 26);
            this.lblCorreoAsociado.Name = "lblCorreoAsociado";
            this.lblCorreoAsociado.Size = new System.Drawing.Size(15, 13);
            this.lblCorreoAsociado.TabIndex = 3;
            this.lblCorreoAsociado.Text = "**";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Correo asociado:";
            // 
            // lblDerechos
            // 
            this.lblDerechos.AutoSize = true;
            this.lblDerechos.Location = new System.Drawing.Point(116, 77);
            this.lblDerechos.Name = "lblDerechos";
            this.lblDerechos.Size = new System.Drawing.Size(250, 13);
            this.lblDerechos.TabIndex = 0;
            this.lblDerechos.TabStop = true;
            this.lblDerechos.Text = "© 2026 Alexandro. Todos los derechos reservados.";
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 510);
            this.Controls.Add(this.groupInformacion);
            this.Controls.Add(this.groupActividades);
            this.Controls.Add(this.groupPresentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VistaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App RRHH";
            this.Load += new System.EventHandler(this.VistaPrincipal_Load);
            this.groupPresentacion.ResumeLayout(false);
            this.groupPresentacion.PerformLayout();
            this.groupActividades.ResumeLayout(false);
            this.groupActividades.PerformLayout();
            this.groupInformacion.ResumeLayout(false);
            this.groupInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPresentacion;
        private System.Windows.Forms.GroupBox groupActividades;
        private System.Windows.Forms.GroupBox groupInformacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnConvertirPDF;
        private System.Windows.Forms.Button btnGenerarDocumentos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnEnviarDocumentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblDerechos;
        private System.Windows.Forms.Label lblConexion;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblNombreEmpleado;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblCorreoAsociado;
    }
}

