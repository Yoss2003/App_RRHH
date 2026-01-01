namespace App_RRHH.Vistas.VistasPrincipales
{
    partial class VistaConvertirPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOrigen = new System.Windows.Forms.GroupBox();
            this.listViewOrigen = new System.Windows.Forms.ListView();
            this.groupBoxDestino = new System.Windows.Forms.GroupBox();
            this.listViewDestino = new System.Windows.Forms.ListView();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBorrarPDF = new System.Windows.Forms.Button();
            this.btnConvertirPDF = new System.Windows.Forms.Button();
            this.lblRutaOrigen = new System.Windows.Forms.LinkLabel();
            this.lblRutaDestino = new System.Windows.Forms.LinkLabel();
            this.groupBoxOrigen.SuspendLayout();
            this.groupBoxDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOrigen
            // 
            this.groupBoxOrigen.Controls.Add(this.lblRutaOrigen);
            this.groupBoxOrigen.Controls.Add(this.listViewOrigen);
            this.groupBoxOrigen.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOrigen.Name = "groupBoxOrigen";
            this.groupBoxOrigen.Size = new System.Drawing.Size(344, 426);
            this.groupBoxOrigen.TabIndex = 7;
            this.groupBoxOrigen.TabStop = false;
            // 
            // listViewOrigen
            // 
            this.listViewOrigen.CheckBoxes = true;
            this.listViewOrigen.HideSelection = false;
            this.listViewOrigen.Location = new System.Drawing.Point(6, 43);
            this.listViewOrigen.Name = "listViewOrigen";
            this.listViewOrigen.Size = new System.Drawing.Size(332, 377);
            this.listViewOrigen.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewOrigen.TabIndex = 1;
            this.listViewOrigen.UseCompatibleStateImageBehavior = false;
            this.listViewOrigen.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxDestino
            // 
            this.groupBoxDestino.Controls.Add(this.lblRutaDestino);
            this.groupBoxDestino.Controls.Add(this.listViewDestino);
            this.groupBoxDestino.Location = new System.Drawing.Point(444, 12);
            this.groupBoxDestino.Name = "groupBoxDestino";
            this.groupBoxDestino.Size = new System.Drawing.Size(344, 426);
            this.groupBoxDestino.TabIndex = 7;
            this.groupBoxDestino.TabStop = false;
            // 
            // listViewDestino
            // 
            this.listViewDestino.CheckBoxes = true;
            this.listViewDestino.HideSelection = false;
            this.listViewDestino.Location = new System.Drawing.Point(6, 43);
            this.listViewDestino.Name = "listViewDestino";
            this.listViewDestino.Size = new System.Drawing.Size(332, 377);
            this.listViewDestino.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewDestino.TabIndex = 1;
            this.listViewDestino.UseCompatibleStateImageBehavior = false;
            this.listViewDestino.View = System.Windows.Forms.View.Details;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(363, 409);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(75, 23);
            this.btnConfiguracion.TabIndex = 12;
            this.btnConfiguracion.Text = "Settings";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Ayuda";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnBorrarPDF
            // 
            this.btnBorrarPDF.Location = new System.Drawing.Point(362, 74);
            this.btnBorrarPDF.Name = "btnBorrarPDF";
            this.btnBorrarPDF.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarPDF.TabIndex = 9;
            this.btnBorrarPDF.Text = "Borrar";
            this.btnBorrarPDF.UseVisualStyleBackColor = true;
            this.btnBorrarPDF.Click += new System.EventHandler(this.btnBorrarPDF_Click);
            // 
            // btnConvertirPDF
            // 
            this.btnConvertirPDF.Location = new System.Drawing.Point(362, 44);
            this.btnConvertirPDF.Name = "btnConvertirPDF";
            this.btnConvertirPDF.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirPDF.TabIndex = 8;
            this.btnConvertirPDF.Text = "Convertir";
            this.btnConvertirPDF.UseVisualStyleBackColor = true;
            // 
            // lblRutaOrigen
            // 
            this.lblRutaOrigen.AutoSize = true;
            this.lblRutaOrigen.Location = new System.Drawing.Point(144, 20);
            this.lblRutaOrigen.Name = "lblRutaOrigen";
            this.lblRutaOrigen.Size = new System.Drawing.Size(15, 13);
            this.lblRutaOrigen.TabIndex = 2;
            this.lblRutaOrigen.TabStop = true;
            this.lblRutaOrigen.Text = "**";
            this.lblRutaOrigen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRutaOrigen_LinkClicked);
            // 
            // lblRutaDestino
            // 
            this.lblRutaDestino.AutoSize = true;
            this.lblRutaDestino.Location = new System.Drawing.Point(185, 20);
            this.lblRutaDestino.Name = "lblRutaDestino";
            this.lblRutaDestino.Size = new System.Drawing.Size(15, 13);
            this.lblRutaDestino.TabIndex = 2;
            this.lblRutaDestino.TabStop = true;
            this.lblRutaDestino.Text = "**";
            this.lblRutaDestino.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRutaDestino_LinkClicked);
            // 
            // VistaConvertirPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnBorrarPDF);
            this.Controls.Add(this.btnConvertirPDF);
            this.Controls.Add(this.groupBoxDestino);
            this.Controls.Add(this.groupBoxOrigen);
            this.Name = "VistaConvertirPDF";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertir a PDF";
            this.Load += new System.EventHandler(this.VistaConvertirPDF_Load);
            this.groupBoxOrigen.ResumeLayout(false);
            this.groupBoxOrigen.PerformLayout();
            this.groupBoxDestino.ResumeLayout(false);
            this.groupBoxDestino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOrigen;
        private System.Windows.Forms.ListView listViewOrigen;
        private System.Windows.Forms.GroupBox groupBoxDestino;
        private System.Windows.Forms.ListView listViewDestino;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBorrarPDF;
        private System.Windows.Forms.Button btnConvertirPDF;
        private System.Windows.Forms.LinkLabel lblRutaOrigen;
        private System.Windows.Forms.LinkLabel lblRutaDestino;
    }
}