namespace Examen_II_Parcial___POO
{
    partial class frmInicio
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
            this.btnIngresarNuevasCanciones = new System.Windows.Forms.Button();
            this.btnEliminarCanciones = new System.Windows.Forms.Button();
            this.btnReporteCanciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarNuevasCanciones
            // 
            this.btnIngresarNuevasCanciones.Location = new System.Drawing.Point(110, 59);
            this.btnIngresarNuevasCanciones.Name = "btnIngresarNuevasCanciones";
            this.btnIngresarNuevasCanciones.Size = new System.Drawing.Size(119, 44);
            this.btnIngresarNuevasCanciones.TabIndex = 0;
            this.btnIngresarNuevasCanciones.Text = "Ingresar Nuevas Canciones";
            this.btnIngresarNuevasCanciones.UseVisualStyleBackColor = true;
            this.btnIngresarNuevasCanciones.Click += new System.EventHandler(this.btnIngresarNuevasCanciones_Click);
            // 
            // btnEliminarCanciones
            // 
            this.btnEliminarCanciones.Location = new System.Drawing.Point(110, 120);
            this.btnEliminarCanciones.Name = "btnEliminarCanciones";
            this.btnEliminarCanciones.Size = new System.Drawing.Size(119, 44);
            this.btnEliminarCanciones.TabIndex = 1;
            this.btnEliminarCanciones.Text = "Eliminar Canciones";
            this.btnEliminarCanciones.UseVisualStyleBackColor = true;
            this.btnEliminarCanciones.Click += new System.EventHandler(this.btnEliminarCanciones_Click);
            // 
            // btnReporteCanciones
            // 
            this.btnReporteCanciones.Location = new System.Drawing.Point(110, 182);
            this.btnReporteCanciones.Name = "btnReporteCanciones";
            this.btnReporteCanciones.Size = new System.Drawing.Size(119, 44);
            this.btnReporteCanciones.TabIndex = 2;
            this.btnReporteCanciones.Text = "Ver Musica";
            this.btnReporteCanciones.UseVisualStyleBackColor = true;
            this.btnReporteCanciones.Click += new System.EventHandler(this.btnReporteCanciones_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 285);
            this.Controls.Add(this.btnReporteCanciones);
            this.Controls.Add(this.btnEliminarCanciones);
            this.Controls.Add(this.btnIngresarNuevasCanciones);
            this.Name = "frmInicio";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarNuevasCanciones;
        private System.Windows.Forms.Button btnEliminarCanciones;
        private System.Windows.Forms.Button btnReporteCanciones;
    }
}

