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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista;
            try
            {
                if (txbCodigo.Text.Length > 0)
                {
                    lista = negocio.Buscar(txbCodigo.Text);
                    txbCategoria.Text = lista[0].categoriaProducto.nombre;
                    txbNombre.Text = lista[0].nombre;
                    txbMarca.Text = lista[0].marcaProducto.nombre;
                    txbDesc.Text = lista[0].descripcion;
                    txbPrecio.Text = Convert.ToString(lista[0].precio);
                }
                else
                 MessageBox.Show("Por favor ingrese un codigo. ");
                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(" El codigo ingresado no existe");
                txbNombre.Text = "";
                txbDesc.Text = "";
                txbMarca.Text = null;
                txbCategoria.Text = null;
                txbPrecio.Text = "";
            }
              catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            negocio.Eiminar(txbCodigo.Text);
            MessageBox.Show("El articulo se ha eliminado.");
            Dispose();
        }

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListado();
            formulario.ShowDialog();
        }
    }
}
