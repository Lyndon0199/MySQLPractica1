using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using MysqlProyect.CapaNegocio;

namespace MysqlProyect
{
    public partial class Lista : System.Web.UI.Page
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);

        public DataTable Listar()
        {
            Libro listar = new Libro();
            GridView1.DataSource = listar.Listar();
            GridView1.DataBind();
            return listar.Listar();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                Listar();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codLibro = txtCodigo.Text.Trim();
            string Titulo = txtTitulo.Text.Trim();
            string Editorial = txtEditorial.Text.Trim();
            Libro listar = new Libro();
            try
            {
                Boolean respuesta = listar.Agregar(codLibro, Titulo, Editorial);
                if (respuesta == true)
                {
                    Response.Write("<script>alert('Agregado Correctamente')</script>");
                    Listar();
                }
                else
                {
                    Response.Write("<script>alert('No se puedo agregar!.')</script>");
                }
            }
            catch (Exception ex)
            {
                conexion.Close();
                Response.Write("Error: " + ex.Message);
            }


        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codLibro = txtCodigo.Text.Trim();
            string Titulo = txtTitulo.Text.Trim();
            string Editorial = txtEditorial.Text.Trim();
            Libro listar = new Libro();
            try
            {
                Boolean respuesta = listar.Actualizar(codLibro, Titulo, Editorial);
                if (respuesta == true)
                {
                    Response.Write("<script>alert('Actualizado Correctamente')</script>");
                    Listar();
                }
                else
                {
                    Response.Write("<script>alert('No se puedo actualizar!.')</script>");
                }
            }
            catch (Exception ex)
            {
                conexion.Close();
                Response.Write("Error: " + ex.Message);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codLibro = txtCodigo.Text.Trim();
            Libro listar = new Libro();
            try
            {
                Boolean respuesta = listar.Eliminar(codLibro);
                if (respuesta == true)
                {
                    Response.Write("<script>alert('Eliminado Correctamente')</script>");
                    Listar();
                }
                else
                {
                    Response.Write("<script>alert('No se puedo Eliminar!.')</script>");
                }
            }
            catch (Exception ex)
            {
                conexion.Close();
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}