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
            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;
            Categoria aux;
            List<Categoria> lista = new List<Categoria>();
            try
            {
                Conexion.ConnectionString = "data source=LENOVO-PC\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = " select Id, Descripcion from CATEGORIAS";
                Comando.Connection = Conexion;
                Conexion.Open();
                Lector = Comando.ExecuteReader();


                while (Lector.Read())
                {
                    aux = new Categoria((int)Lector["Id"], (string)Lector["Descripcion"]);
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
                Conexion.Close();
            }


        }
    }
}
