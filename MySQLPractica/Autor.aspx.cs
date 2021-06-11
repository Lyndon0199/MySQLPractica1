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
    public partial class Autores : System.Web.UI.Page
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static MySqlConnection conexion = new MySqlConnection(cadena);

        public DataTable Listar()
        {
            Autor listar = new Autor();
            gvTabla.DataSource = listar.Listar();
            gvTabla.DataBind();
            return listar.Listar();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codAutor = txtCodigoAutor.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();
            Autor listar = new Autor();
            try
            {
                Boolean respuesta = listar.Agregar(codAutor, apellidos, nombres, nacionalidad);
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
            string codAutor = txtCodigoAutor.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();
            Autor listar = new Autor();
            try
            {
                Boolean respuesta = listar.Actualizar(codAutor, apellidos, nombres, nacionalidad);
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
            string codAutor = txtCodigoAutor.Text.Trim();
            Autor listar = new Autor();
            try
            {
                Boolean respuesta = listar.Eliminar(codAutor);
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