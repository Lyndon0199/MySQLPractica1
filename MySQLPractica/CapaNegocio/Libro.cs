using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;



namespace MysqlProyect.CapaNegocio
{
    public class Libro : Ilibro
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);
        public bool Actualizar(string codLibro, string titulo, string editorial)
        {

            string consulta = "update tlibro set Titulo = @Titulo, Editorial = @Editorial where CodLibro = @CodLibro";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@CodLibro", codLibro);
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@Editorial", editorial);
            conexion.Open();
            var result = comando.ExecuteScalar();
            bool i = result != null ? (int)result > 0 : true;
            conexion.Close();
            return i;
        }

        public bool Agregar(string codLibro, string titulo, string editorial)
        {
            string consulta = "Insert into tlibro values(@CodLibro,@Titulo,@Editorial)";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@CodLibro", codLibro);
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@Editorial", editorial);
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

        public bool Eliminar(string codLibro)
        {
            string consulta = "delete from tlibro where CodLibro='" + codLibro + "'";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            conexion.Open();
            var result = comando.ExecuteScalar();
            bool i = result != null ? (int)result > 0 : true;
            conexion.Close();
            return i;
        }

        public DataTable Listar()
        {
            string consulta = "select * from tlibro";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            return tabla;
        }
    }
}