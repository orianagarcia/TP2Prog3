using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dominios;
using System.Windows.Forms;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;

            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=LENOVO-PC\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Codigo, Nombre,articulos.Descripcion, Precio, MARCAS.Descripcion as 'Marca', CATEGORIAS.Descripcion as 'Categoria' From ARTICULOS inner join MARCAS on ARTICULOS.IdMarca=MARCAS.Id inner join CATEGORIAS on ARTICULOS.IdCategoria=CATEGORIAS.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    aux = new Articulo();
                    aux.codigo = lector.GetString(0);
                    aux.nombre = lector.GetString(1);
                    aux.descripcion = lector.GetString(2);
                    aux.precio = lector.GetDecimal(3);
                    aux.marcaProducto = new Marca();
                    aux.marcaProducto.nombre = lector.GetString(4);
                    aux.categoriaProducto = new Categoria();
                    aux.categoriaProducto.nombre = lector.GetString(5);

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
                conexion.Close();
            }
        }

        public void agregar(Articulo aux)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=LENOVO-PC\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "Insert into ARTICULOS values ( @codigo,@nombre,  @desc , @marca, @categoria, 'Ruta imagen', @precio, @estado)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo", aux.codigo);
                comando.Parameters.AddWithValue("@nombre", aux.nombre);
                comando.Parameters.AddWithValue("@desc", aux.descripcion);
                comando.Parameters.AddWithValue("@marca", aux.marcaProducto.id);
                comando.Parameters.AddWithValue("@categoria", aux.categoriaProducto.id);
                comando.Parameters.AddWithValue("@precio", aux.precio);
                comando.Parameters.AddWithValue("@estado", true);

                comando.Connection = conexion;
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
        public List<Articulo> Buscar(string codigo)
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;

            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=LENOVO-PC\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select articulos.id, Codigo, Nombre,articulos.Descripcion, Precio, MARCAS.Descripcion as 'Marca', CATEGORIAS.Descripcion as 'Categoria' From ARTICULOS  inner join MARCAS on ARTICULOS.IdMarca=MARCAS.Id inner join CATEGORIAS on ARTICULOS.IdCategoria=CATEGORIAS.Id where articulos.codigo= '" + codigo+"'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Articulo();
                    aux.id = lector.GetInt32(0);
                    aux.codigo = lector.GetString(1);
                    aux.nombre = lector.GetString(2);
                    aux.descripcion = lector.GetString(3);
                    aux.precio = lector.GetDecimal(4);
                    aux.marcaProducto = new Marca();
                    aux.marcaProducto.nombre = lector.GetString(5);
                    aux.categoriaProducto = new Categoria();
                    aux.categoriaProducto.nombre = lector.GetString(6);

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
                conexion.Close();
            }
        }
        public void Eiminar(string codigo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=LENOVO-PC\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = " delete from ARTICULOS where codigo = '" + codigo +"'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Modificar(Articulo aux)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=LENOVO-PC\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "update ARTICULOS set Codigo = @codigo where ID = @Id;update ARTICULOS set Nombre = @nombre where ID = @Id;update ARTICULOS set Descripcion = @desc where ID = @Id;update ARTICULOS set IdMarca =@marca where ID = @Id;update ARTICULOS set IdCategoria = @categoria where ID = @Id;update ARTICULOS set Precio = @precio where ID = @Id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id", aux.id);
                comando.Parameters.AddWithValue("@codigo", aux.codigo);
                comando.Parameters.AddWithValue("@nombre", aux.nombre);
                comando.Parameters.AddWithValue("@desc", aux.descripcion);
                comando.Parameters.AddWithValue("@marca", aux.marcaProducto.id);
                comando.Parameters.AddWithValue("@categoria", aux.categoriaProducto.id);
                comando.Parameters.AddWithValue("@precio", aux.precio);

                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexion.Close();
            }


        

            
           
        }
    }
}

