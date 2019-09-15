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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void validarLetras(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            try
            {
                articulo.codigo = txbCodigo.Text;
                articulo.nombre = txbNombre.Text;
                articulo.descripcion = txbDesc.Text;
                articulo.precio = Convert.ToDecimal(txbPrecio.Text);
                articulo.marcaProducto= (Marca)cboMarca.SelectedItem;
                articulo.categoriaProducto = (Categoria)cboCategoria.SelectedItem;

                articuloNegocio.agregar(articulo);
                MessageBox.Show("El articulo se agrego correctamente.");
                Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();
            try
            {
                articulo.codigo = (txbCodigo.Text).ToString();
                articulo.nombre = txbNombre.Text;
                articulo.marcaProducto = (Marca)cboMarca.SelectedItem;
                articulo.categoriaProducto = (Categoria)cboCategoria.SelectedItem;
                articulo.descripcion = txbDesc.Text;
                articulo.precio = decimal.Parse(txbPrecio.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marca.Listado();
                cboCategoria.DataSource = categoria.Listado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
