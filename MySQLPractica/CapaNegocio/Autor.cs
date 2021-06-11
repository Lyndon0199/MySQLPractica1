using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace MysqlProyect.CapaNegocio
{
    public class Autor : IAutor
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);
        public bool Actualizar(string codAutor, string Apellidos, string Nombres, string Nacionalidad)
        {

            string consulta = "update tautor set Apellidos = @apellidos, Nombres = @nombres, Nacionalidad = @nacionalidad where CodAutor = @codautor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@codautor", codAutor);
            comando.Parameters.AddWithValue("@apellidos", Apellidos);
            comando.Parameters.AddWithValue("@nombres", Nombres);
            comando.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
            conexion.Open();
            var result = comando.ExecuteScalar();
            bool i = result != null ? (int)result > 0 : true;
            conexion.Close();
            return i;
        }

        public bool Agregar(string codAutor, string Apellidos, string Nombres, string Nacionalidad)
        {

            string consulta = "Insert into tautor values(@codautor,@apellidos,@nombres,@nacionalidad)";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // envio de parametros
            comando.Parameters.AddWithValue("@codautor", codAutor);
            comando.Parameters.AddWithValue("@apellidos", Apellidos);
            comando.Parameters.AddWithValue("@nombres", Nombres);
            comando.Parameters.AddWithValue("@nacionalidad", Nacionalidad);


            // ejecutar insert

            conexion.Open();
            var result = comando.ExecuteScalar();
            bool i = result != null ? (int)result > 0 : true;
            conexion.Close();
            return i;
        }

        public DataTable Buscar(string texto, string criterio)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(string codAutor)
        {
            string consulta = "delete from tautor where codautor='" + codAutor + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Open();
            var result = comando.ExecuteScalar();
            bool i = result != null ? (int)result > 0 : true;
            conexion.Close();
            return i;
        }

        public DataTable Listar()
        {
            string consulta = "select * from TAutor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}