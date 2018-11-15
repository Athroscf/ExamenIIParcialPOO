using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Examen_II_Parcial___POO
{
    public partial class frmMostrarMusica : Form
    {
        public frmMostrarMusica()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMostrarMusica_Load(object sender, EventArgs e)
        {
            Models.Conexion conn = new Models.Conexion();
            var cmd = "select Nombre, Genero, AñoCreacion from Musica.Cancion INNER JOIN Musica.Artista AS a ON a.Nombre INNER JOIN Musica.Album AS al ON al.Nombre";
            var c = new SqlConnection(conn); // Tu String de conexión
            //Creacion del DataAdapter
            var adaptador = new SqlDataAdapter(cmd, c);
            
            var commandBuilder = new SqlCommandBuilder(adaptador);
            //Creacion del DataSet
            var ds = new DataSet();
            //Se llena el GridView
            adaptador.Fill(ds);
            gvMostrarMusica.ReadOnly = true;
            gvMostrarMusica.DataSource = ds.Tables[0];
        }
    }
}
