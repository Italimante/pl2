namespace Formulario
{
    partial class FrmPpal
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxEstados = new System.Windows.Forms.GroupBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEstadoEntregado = new System.Windows.Forms.Label();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.labelEstadoEnViaje = new System.Windows.Forms.Label();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.labelEstadoIngresado = new System.Windows.Forms.Label();
            this.groupBoxPaquete = new System.Windows.Forms.GroupBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTrackingID = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.groupBoxEstados.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.groupBoxPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEstados
            // 
            this.groupBoxEstados.Controls.Add(this.lstEstadoEntregado);
            this.groupBoxEstados.Controls.Add(this.labelEstadoEntregado);
            this.groupBoxEstados.Controls.Add(this.lstEstadoEnViaje);
            this.groupBoxEstados.Controls.Add(this.labelEstadoEnViaje);
            this.groupBoxEstados.Controls.Add(this.lstEstadoIngresado);
            this.groupBoxEstados.Controls.Add(this.labelEstadoIngresado);
            this.groupBoxEstados.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEstados.Name = "groupBoxEstados";
            this.groupBoxEstados.Size = new System.Drawing.Size(636, 273);
            this.groupBoxEstados.TabIndex = 0;
            this.groupBoxEstados.TabStop = false;
            this.groupBoxEstados.Text = "Estados de los paquetes";
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(429, 42);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(189, 212);
            this.lstEstadoEntregado.TabIndex = 5;
            // 
            // cmsListas
            // 
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MostrarToolStripMenuItem});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(116, 26);
            // 
            // MostrarToolStripMenuItem
            // 
            this.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem";
            this.MostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.MostrarToolStripMenuItem.Text = "Mostrar";
            this.MostrarToolStripMenuItem.Click += new System.EventHandler(this.MostrarToolStripMenuItem_Click);
            // 
            // labelEstadoEntregado
            // 
            this.labelEstadoEntregado.AutoSize = true;
            this.labelEstadoEntregado.Location = new System.Drawing.Point(426, 26);
            this.labelEstadoEntregado.Name = "labelEstadoEntregado";
            this.labelEstadoEntregado.Size = new System.Drawing.Size(56, 13);
            this.labelEstadoEntregado.TabIndex = 4;
            this.labelEstadoEntregado.Text = "Entregado";
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(224, 42);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(189, 212);
            this.lstEstadoEnViaje.TabIndex = 3;
            // 
            // labelEstadoEnViaje
            // 
            this.labelEstadoEnViaje.AutoSize = true;
            this.labelEstadoEnViaje.Location = new System.Drawing.Point(221, 26);
            this.labelEstadoEnViaje.Name = "labelEstadoEnViaje";
            this.labelEstadoEnViaje.Size = new System.Drawing.Size(45, 13);
            this.labelEstadoEnViaje.TabIndex = 2;
            this.labelEstadoEnViaje.Text = "En viaje";
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(19, 42);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(189, 212);
            this.lstEstadoIngresado.TabIndex = 1;
            // 
            // labelEstadoIngresado
            // 
            this.labelEstadoIngresado.AutoSize = true;
            this.labelEstadoIngresado.Location = new System.Drawing.Point(16, 26);
            this.labelEstadoIngresado.Name = "labelEstadoIngresado";
            this.labelEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.labelEstadoIngresado.TabIndex = 0;
            this.labelEstadoIngresado.Text = "Ingresado";
            // 
            // groupBoxPaquete
            // 
            this.groupBoxPaquete.Controls.Add(this.labelDireccion);
            this.groupBoxPaquete.Controls.Add(this.labelTrackingID);
            this.groupBoxPaquete.Controls.Add(this.txtDireccion);
            this.groupBoxPaquete.Controls.Add(this.mtxtTrackingID);
            this.groupBoxPaquete.Controls.Add(this.btnMostrarTodos);
            this.groupBoxPaquete.Controls.Add(this.btnAgregar);
            this.groupBoxPaquete.Location = new System.Drawing.Point(393, 291);
            this.groupBoxPaquete.Name = "groupBoxPaquete";
            this.groupBoxPaquete.Size = new System.Drawing.Size(255, 137);
            this.groupBoxPaquete.TabIndex = 0;
            this.groupBoxPaquete.TabStop = false;
            this.groupBoxPaquete.Text = "Paquete";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(19, 69);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Dirección";
            // 
            // labelTrackingID
            // 
            this.labelTrackingID.AutoSize = true;
            this.labelTrackingID.Location = new System.Drawing.Point(19, 30);
            this.labelTrackingID.Name = "labelTrackingID";
            this.labelTrackingID.Size = new System.Drawing.Size(60, 13);
            this.labelTrackingID.TabIndex = 4;
            this.labelTrackingID.Text = "TrackingID";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(22, 88);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(22, 46);
            this.mtxtTrackingID.Mask = "00-00-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(100, 20);
            this.mtxtTrackingID.TabIndex = 2;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(128, 85);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarTodos.TabIndex = 1;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(128, 44);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(12, 291);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(375, 137);
            this.rtbMostrar.TabIndex = 1;
            this.rtbMostrar.Text = "";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 440);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.groupBoxPaquete);
            this.Controls.Add(this.groupBoxEstados);
            this.MaximizeBox = false;
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo UTN por Caballero.Streppel.Andrés.2C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.groupBoxEstados.ResumeLayout(false);
            this.groupBoxEstados.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.groupBoxPaquete.ResumeLayout(false);
            this.groupBoxPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEstados;
        private System.Windows.Forms.GroupBox groupBoxPaquete;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.Label labelEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.Label labelEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.Label labelEstadoEnViaje;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem MostrarToolStripMenuItem;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTrackingID;
    }
}