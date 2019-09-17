using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Negocio
{
   public class AccesoDatos
    {
        public SqlDataReader lector;

        public SqlCommand comando;

        public SqlConnection conexion;

        public AccesoDatos()
        {
           conexion = new SqlConnection("data source=LENOVO-PC\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi");
           comando = new SqlCommand();
           comando.Connection = conexion; 
        }
        public void setearQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void agregarParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void ejecutarLector()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }
        internal void ejecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void Clear()
        {
            comando.Parameters.Clear();
        }

    }
}
