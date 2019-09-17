using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listado()
        {
            AccesoDatos datos = new AccesoDatos();
            Categoria aux;
            List<Categoria> lista = new List<Categoria>();
            try
            {
                datos.setearQuery( " select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLector();


                while (datos.lector.Read())
                {
                    aux = new Categoria((int)datos.lector["Id"], (string)datos.lector["Descripcion"]);
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
    }
}
