using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se agregan los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace Examen_II_Parcial___POO.Models
{
    class Musica
    {
        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string year { get; set; }

        public void Insertar()
        {
            //Se llama al SP
            Models.Conexion con = new Models.Conexion();
            SqlCommand cmd = new SqlCommand(@"SP_Insert");
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                //Se conecta con la BD y se le asignan los parametros al SP
                con.EstablecerConexion();
                cmd.Parameters.Add("Nombre", SqlDbType.NVarChar, 200);
                cmd.Parameters["Nombre"].Value = name;
                cmd.Parameters.Add("Genero", SqlDbType.NVarChar, 100);
                cmd.Parameters["Genero"].Value = genre;
                cmd.Parameters.Add("AñoCreacion", SqlDbType.NVarChar, 4);
                cmd.Parameters["AñoCreacion"].Value = year;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new Exception();
            }
            finally
            {
                //Cierre de Conexion
                con.CerrarConexion();
            }
        }

        public void Delete()
        {

        }
    }
}
