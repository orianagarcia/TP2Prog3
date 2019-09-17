using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominios;
using System.Windows.Forms;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listado ()
        {
            AccesoDatos datos = new AccesoDatos();
            Marca aux;
            List<Marca> lista = new List<Marca>();
            try
            {
                datos.setearQuery( " select Id, Descripcion from MARCAS");
                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Marca((int)datos.lector["Id"], (string)datos.lector["Descripcion"]);
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
                datos.cerrarConexion();                }


        }

    }
}
