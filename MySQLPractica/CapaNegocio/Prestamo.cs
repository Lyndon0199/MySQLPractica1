using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MysqlProyect.CapaNegocio
{
    public class Prestamo : IPrestamo
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);
        public bool Actualizar(string codAutor, string codLibro, string fecha)
        {
            string consulta = "update tprestamo set CodLibro = @CodLibro, FechaPrestamo = @FechaPrestamo where CodAutor = @CodAutor";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@CodAutor", codAutor);
            comando.Parameters.AddWithValue("@CodLibro", codLibro);
            comando.Parameters.AddWithValue("@FechaPrestamo", fecha);
            conexion.Open();
            var result = comando.ExecuteScalar();
            bool i = result != null ? (int)result > 0 : true;
            conexion.Close();
            return i;
        }

        public bool Agregar(string codAutor, string codLibro, string fecha)
        {
            string consulta = "Insert into tprestamo values(@CodAutor,@CodLibro,@FechaPrestamo)";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@CodAutor", codAutor);
            comando.Parameters.AddWithValue("@CodLibro", codLibro);
            comando.Parameters.AddWithValue("@FechaPrestamo", fecha);
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
            string consulta = "delete from tprestamo where codAutor='" + codAutor + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Open();
            var result = comando.ExecuteScalar();
            bool i = result != null ? (int)result > 0 : true;
            conexion.Close();
            return i;
        }

        public DataTable Listar()
        {
            string consulta = "select * from tprestamo";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}