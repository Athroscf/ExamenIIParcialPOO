namespace Examen_II_Parcial___POO
{
    partial class frmIngresarCanciones
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
            this.btnIngresarCancion = new System.Windows.Forms.Button();
            this.txtNombreCancion = new System.Windows.Forms.TextBox();
            this.lblNombreCancion = new System.Windows.Forms.Label();
            this.lvArtistas = new System.Windows.Forms.ListView();
            this.lvAlbumes = new System.Windows.Forms.ListView();
            this.lblArtistas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGeneroCancion = new System.Windows.Forms.Label();
            this.txtGeneroCancion = new System.Windows.Forms.TextBox();
            this.lblAñoCreacion = new System.Windows.Forms.Label();
            this.txtAñoCreacion = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarCancion
            // 
            this.btnIngresarCancion.Location = new System.Drawing.Point(176, 299);
            this.btnIngresarCancion.Name = "btnIngresarCancion";
            this.btnIngresarCancion.Size = new System.Drawing.Size(94, 39);
            this.btnIngresarCancion.TabIndex = 0;
            this.btnIngresarCancion.Text = "Ingresar Cancion";
            this.btnIngresarCancion.UseVisualStyleBackColor = true;
            this.btnIngresarCancion.Click += new System.EventHandler(this.btnIngresarCancion_Click);
            // 
            // txtNombreCancion
            // 
            this.txtNombreCancion.Location = new System.Drawing.Point(141, 44);
            this.txtNombreCancion.Name = "txtNombreCancion";
            this.txtNombreCancion.Size = new System.Drawing.Size(162, 20);
            this.txtNombreCancion.TabIndex = 1;
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.Location = new System.Drawing.Point(34, 47);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(101, 13);
            this.lblNombreCancion.TabIndex = 2;
            this.lblNombreCancion.Text = "Nombre de Cancion";
            // 
            // lvArtistas
            // 
            this.lvArtistas.Location = new System.Drawing.Point(37, 147);
            this.lvArtistas.Name = "lvArtistas";
            this.lvArtistas.Size = new System.Drawing.Size(217, 133);
            this.lvArtistas.TabIndex = 3;
            this.lvArtistas.UseCompatibleStateImageBehavior = false;
            // 
            // lvAlbumes
            // 
            this.lvAlbumes.Location = new System.Drawing.Point(333, 147);
            this.lvAlbumes.Name = "lvAlbumes";
            this.lvAlbumes.Size = new System.Drawing.Size(220, 133);
            this.lvAlbumes.TabIndex = 4;
            this.lvAlbumes.UseCompatibleStateImageBehavior = false;
            // 
            // lblArtistas
            // 
            this.lblArtistas.AutoSize = true;
            this.lblArtistas.Location = new System.Drawing.Point(37, 128);
            this.lblArtistas.Name = "lblArtistas";
            this.lblArtistas.Size = new System.Drawing.Size(41, 13);
            this.lblArtistas.TabIndex = 5;
            this.lblArtistas.Text = "Artistas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Albumes";
            // 
            // lblGeneroCancion
            // 
            this.lblGeneroCancion.AutoSize = true;
            this.lblGeneroCancion.Location = new System.Drawing.Point(34, 75);
            this.lblGeneroCancion.Name = "lblGeneroCancion";
            this.lblGeneroCancion.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroCancion.TabIndex = 8;
            this.lblGeneroCancion.Text = "Genero";
            // 
            // txtGeneroCancion
            // 
            this.txtGeneroCancion.Location = new System.Drawing.Point(141, 72);
            this.txtGeneroCancion.Name = "txtGeneroCancion";
            this.txtGeneroCancion.Size = new System.Drawing.Size(162, 20);
            this.txtGeneroCancion.TabIndex = 7;
            // 
            // lblAñoCreacion
            // 
            this.lblAñoCreacion.AutoSize = true;
            this.lblAñoCreacion.Location = new System.Drawing.Point(339, 44);
            this.lblAñoCreacion.Name = "lblAñoCreacion";
            this.lblAñoCreacion.Size = new System.Drawing.Size(26, 13);
            this.lblAñoCreacion.TabIndex = 10;
            this.lblAñoCreacion.Text = "Año";
            // 
            // txtAñoCreacion
            // 
            this.txtAñoCreacion.Location = new System.Drawing.Point(391, 40);
            this.txtAñoCreacion.Name = "txtAñoCreacion";
            this.txtAñoCreacion.Size = new System.Drawing.Size(162, 20);
            this.txtAñoCreacion.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(292, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 39);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmIngresarCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAñoCreacion);
            this.Controls.Add(this.txtAñoCreacion);
            this.Controls.Add(this.lblGeneroCancion);
            this.Controls.Add(this.txtGeneroCancion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArtistas);
            this.Controls.Add(this.lvAlbumes);
            this.Controls.Add(this.lvArtistas);
            this.Controls.Add(this.lblNombreCancion);
            this.Controls.Add(this.txtNombreCancion);
            this.Controls.Add(this.btnIngresarCancion);
            this.Name = "frmIngresarCanciones";
            this.Text = "Nuevas Musica";
            this.Load += new System.EventHandler(this.frmIngresarCanciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarCancion;
        private System.Windows.Forms.TextBox txtNombreCancion;
        private System.Windows.Forms.Label lblNombreCancion;
        private System.Windows.Forms.ListView lvArtistas;
        private System.Windows.Forms.ListView lvAlbumes;
        private System.Windows.Forms.Label lblArtistas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGeneroCancion;
        private System.Windows.Forms.TextBox txtGeneroCancion;
        private System.Windows.Forms.Label lblAñoCreacion;
        private System.Windows.Forms.TextBox txtAñoCreacion;
        private System.Windows.Forms.Button btnSalir;
    }
}