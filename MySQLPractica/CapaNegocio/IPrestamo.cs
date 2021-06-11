using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MysqlProyect.CapaNegocio
{
    interface IPrestamo
    {
        DataTable Listar();

        bool Agregar(string codAutor, string codLibro, string fecha);

        bool Eliminar(string codAutor);

        bool Actualizar(string codAutor, string codLibro, string fecha);

        DataTable Buscar(string texto, string criterio);
    }
}
