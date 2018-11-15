namespace Examen_II_Parcial___POO
{
    partial class frmMostrarMusica
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
            this.gvMostrarMusica = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMostrarMusica)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMostrarMusica
            // 
            this.gvMostrarMusica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMostrarMusica.Location = new System.Drawing.Point(12, 12);
            this.gvMostrarMusica.Name = "gvMostrarMusica";
            this.gvMostrarMusica.Size = new System.Drawing.Size(493, 263);
            this.gvMostrarMusica.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(520, 234);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMostrarMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 287);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gvMostrarMusica);
            this.Name = "frmMostrarMusica";
            this.Text = "frmMostrarMusica";
            this.Load += new System.EventHandler(this.frmMostrarMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMostrarMusica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMostrarMusica;
        private System.Windows.Forms.Button btnSalir;
    }
}