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

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("Select Codigo, Nombre,articulos.Descripcion, Precio, MARCAS.Descripcion as 'Marca', CATEGORIAS.Descripcion as 'Categoria' From ARTICULOS inner join MARCAS on ARTICULOS.IdMarca=MARCAS.Id inner join CATEGORIAS on ARTICULOS.IdCategoria=CATEGORIAS.Id where estado = 1;");
                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Articulo();
                    aux.codigo = datos.lector.GetString(0);
                    aux.nombre = datos.lector.GetString(1);
                    aux.descripcion = datos.lector.GetString(2);
                    aux.precio = datos.lector.GetDecimal(3);
                    aux.marcaProducto = new Marca();
                    aux.marcaProducto.nombre = datos.lector.GetString(4);
                    aux.categoriaProducto = new Categoria();
                    aux.categoriaProducto.nombre = datos.lector.GetString(5);

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

        public void agregar(Articulo aux)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                
                datos.setearQuery("Insert into ARTICULOS values ( @codigo,@nombre,  @desc , @marca, @categoria, 'Ruta imagen', @precio, @estado)");
                datos.Clear();
                datos.agregarParametro("@codigo", aux.codigo);
                datos.agregarParametro("@nombre", aux.nombre);
                datos.agregarParametro("@desc", aux.descripcion);
                datos.agregarParametro("@marca", aux.marcaProducto.id);
                datos.agregarParametro("@categoria", aux.categoriaProducto.id);
                datos.agregarParametro("@precio", aux.precio);
                datos.agregarParametro("@estado", true);
                datos.ejecutarAccion();

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
        public List<Articulo> Buscar(string codigo)
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;

            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearQuery("select articulos.id, Codigo, Nombre,articulos.Descripcion, Precio, MARCAS.Descripcion as 'Marca', CATEGORIAS.Descripcion as 'Categoria' From ARTICULOS  inner join MARCAS on ARTICULOS.IdMarca=MARCAS.Id inner join CATEGORIAS on ARTICULOS.IdCategoria=CATEGORIAS.Id where articulos.codigo= '"+codigo+" ' and ARTICULOS.Estado=1");
                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    aux = new Articulo();
                    aux.id = datos.lector.GetInt32(0);
                    aux.codigo = datos.lector.GetString(1);
                    aux.nombre = datos.lector.GetString(2);
                    aux.descripcion = datos.lector.GetString(3);
                    aux.precio = datos.lector.GetDecimal(4);
                    aux.marcaProducto = new Marca();
                    aux.marcaProducto.nombre = datos.lector.GetString(5);
                    aux.categoriaProducto = new Categoria();
                    aux.categoriaProducto.nombre = datos.lector.GetString(6);

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
        public void Eiminar(string cod)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("update articulos set estado = 0 where codigo = '"+cod+"'");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Modificar(Articulo aux)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("update ARTICULOS set Codigo = @codigo where ID = @Id;update ARTICULOS set Nombre = @nombre where ID = @Id;update ARTICULOS set Descripcion = @desc where ID = @Id;update ARTICULOS set IdMarca =@marca where ID = @Id;update ARTICULOS set IdCategoria = @categoria where ID = @Id;update ARTICULOS set Precio = @precio where ID = @Id");
                datos.Clear();
                datos.agregarParametro("@Id", aux.id);
                datos.agregarParametro("@codigo", aux.codigo);
                datos.agregarParametro("@nombre", aux.nombre);
                datos.agregarParametro("@desc", aux.descripcion);
                datos.agregarParametro("@marca", aux.marcaProducto.id);
                datos.agregarParametro("@categoria", aux.categoriaProducto.id);
                datos.agregarParametro("@precio", aux.precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                datos.cerrarConexion();
            }
                         

            
           
        }
    }
}

