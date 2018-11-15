using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_II_Parcial___POO
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIngresarNuevasCanciones_Click(object sender, EventArgs e)
        {
            frmIngresarCanciones ic = new frmIngresarCanciones();
            ic.Show();
        }

        private void btnEliminarCanciones_Click(object sender, EventArgs e)
        {
            frmEliminarCancion ec = new frmEliminarCancion();
            ec.Show();
        }

        private void btnReporteCanciones_Click(object sender, EventArgs e)
        {
            frmMostrarMusica ms = new frmMostrarMusica();
            ms.Show();
        }
    }
}
