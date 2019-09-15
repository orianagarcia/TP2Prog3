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
            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;
            Marca aux;
            List<Marca> lista = new List<Marca>();
            try
            {
                Conexion.ConnectionString = "data source=LENOVO-PC\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = " select Id, Descripcion from MARCAS";
                Comando.Connection = Conexion;
                Conexion.Open();
                 Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    aux = new Marca((int)Lector["Id"], (string)Lector["Descripcion"]);
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
