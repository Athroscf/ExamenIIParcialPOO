﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Se agregan los namespaces necesarios
using System.Data.SqlClient;

namespace Examen_II_Parcial___POO.Models
{
    class Conexion
    {
        // Propiedades
        private string servidor;
        private string baseDatos;
        public SqlConnection conn;
        public SqlCommand cmd;

        // Constructores
        public Conexion() { }

        public Conexion(string elServidor, string laBaseDatos)
        {
            servidor = elServidor;
            baseDatos = laBaseDatos;
            EstablecerConexion();
        }

        // Métodos
        /// <summary>
        /// Realiza una conexión al servidor de base de datos.
        /// Requiere el nombre del servidor más la instancia del mismo.
        /// Requiere el nombre de la base de datos a inicializar.
        /// </summary>
        public void EstablecerConexion()
        {
            try
            {
                conn = new SqlConnection(@"server = (local)\chrisfiallos;" +
                    "integrated security = true; database = BulletProofRecords");

                // Establecer conexión
                conn.Open();
            }
            catch (SqlException)
            {
                throw new Exception("¡Servidor o base de datos no encontrados!");
            }
        }

        /// <summary>
        /// Ejecuta un comando SQL.
        /// </summary>
        /// <param name="elComando">El query SQL a ejecutar</param>
        public SqlCommand EjecutarComando(string elComando)
        {
            return cmd = new SqlCommand(elComando, conn);
        }

        /// <summary>
        /// Cierra la conexión al servidor SQL.
        /// </summary>
        public void CerrarConexion()
        {
            conn.Close();
        }
    }
}
