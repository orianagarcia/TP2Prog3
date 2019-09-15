using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominios;

namespace PROG3_TP2_Gaarcia_Oriana
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista;
            try
            {
                if (txbCodigo.TextLength > 0)
                {
                    lista = negocio.Buscar(txbCodigo.Text);
                    txbID.Text = lista[0].id.ToString();
                    txbDesc.Text = lista[0].descripcion;
                    txbNombre.Text = lista[0].nombre;
                    txbDesc.Text = lista[0].nombre;
                    cboMarca.Text = lista[0].marcaProducto.nombre;
                    cboCategoria.Text = lista[0].categoriaProducto.nombre;
                    txbPrecio.Text = lista[0].precio.ToString();
                }
                else
                    MessageBox.Show("Por favor,Ingrese un codigo.");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(" El codigo ingresado no existe");
                txbNombre.Text = "";
                txbDesc.Text = "";
                cboMarca.DataSource = null;
                cboCategoria.DataSource = null;
                txbPrecio.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marca.Listado();
                cboMarca.SelectedItem = null;
                cboCategoria.DataSource = categoria.Listado();
                cboCategoria.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            List < Articulo > lista = new List<Articulo>();
            try
            {
                lista = negocio.Buscar(txbCodigo.Text);
                articulo = lista[0];
                articulo.codigo = txbCodigo.Text;
                articulo.descripcion = txbDesc.Text;
                articulo.categoriaProducto =(Categoria)cboCategoria.SelectedItem;
                articulo.marcaProducto = (Marca)cboMarca.SelectedItem;
                articulo.precio = decimal.Parse(txbPrecio.Text);
                negocio.Modificar(articulo);
                MessageBox.Show("El articulo se ha modificado.");
                Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
