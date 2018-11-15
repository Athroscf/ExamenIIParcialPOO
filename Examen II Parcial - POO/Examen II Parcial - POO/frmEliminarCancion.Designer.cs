namespace Examen_II_Parcial___POO
{
    partial class frmEliminarCancion
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
            this.lblNombreCancion = new System.Windows.Forms.Label();
            this.txtNombreCancion = new System.Windows.Forms.TextBox();
            this.gvEliminarCancion = new System.Windows.Forms.DataGridView();
            this.btnEliminarCancion = new System.Windows.Forms.Button();
            this.btnCancelarEliminarCancion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvEliminarCancion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.Location = new System.Drawing.Point(29, 30);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(46, 13);
            this.lblNombreCancion.TabIndex = 0;
            this.lblNombreCancion.Text = "Cancion";
            // 
            // txtNombreCancion
            // 
            this.txtNombreCancion.Location = new System.Drawing.Point(81, 27);
            this.txtNombreCancion.Name = "txtNombreCancion";
            this.txtNombreCancion.Size = new System.Drawing.Size(150, 20);
            this.txtNombreCancion.TabIndex = 1;
            // 
            // gvEliminarCancion
            // 
            this.gvEliminarCancion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEliminarCancion.Location = new System.Drawing.Point(81, 69);
            this.gvEliminarCancion.Name = "gvEliminarCancion";
            this.gvEliminarCancion.Size = new System.Drawing.Size(308, 66);
            this.gvEliminarCancion.TabIndex = 2;
            // 
            // btnEliminarCancion
            // 
            this.btnEliminarCancion.Location = new System.Drawing.Point(81, 175);
            this.btnEliminarCancion.Name = "btnEliminarCancion";
            this.btnEliminarCancion.Size = new System.Drawing.Size(93, 30);
            this.btnEliminarCancion.TabIndex = 3;
            this.btnEliminarCancion.Text = "Eliminar Cancion";
            this.btnEliminarCancion.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEliminarCancion
            // 
            this.btnCancelarEliminarCancion.Location = new System.Drawing.Point(214, 175);
            this.btnCancelarEliminarCancion.Name = "btnCancelarEliminarCancion";
            this.btnCancelarEliminarCancion.Size = new System.Drawing.Size(93, 30);
            this.btnCancelarEliminarCancion.TabIndex = 4;
            this.btnCancelarEliminarCancion.Text = "Cancelar";
            this.btnCancelarEliminarCancion.UseVisualStyleBackColor = true;
            this.btnCancelarEliminarCancion.Click += new System.EventHandler(this.btnCancelarEliminarCancion_Click);
            // 
            // frmEliminarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 229);
            this.Controls.Add(this.btnCancelarEliminarCancion);
            this.Controls.Add(this.btnEliminarCancion);
            this.Controls.Add(this.gvEliminarCancion);
            this.Controls.Add(this.txtNombreCancion);
            this.Controls.Add(this.lblNombreCancion);
            this.Name = "frmEliminarCancion";
            this.Text = "Eliminar Canciones";
            ((System.ComponentModel.ISupportInitialize)(this.gvEliminarCancion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCancion;
        private System.Windows.Forms.TextBox txtNombreCancion;
        private System.Windows.Forms.DataGridView gvEliminarCancion;
        private System.Windows.Forms.Button btnEliminarCancion;
        private System.Windows.Forms.Button btnCancelarEliminarCancion;
    }
}