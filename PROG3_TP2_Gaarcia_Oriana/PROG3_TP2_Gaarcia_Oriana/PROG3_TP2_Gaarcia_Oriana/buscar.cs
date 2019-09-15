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
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        private void BuscarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                dgvBuscarDatos.DataSource = negocio.Buscar(txbBusqueda.Text);
                dgvBuscarDatos.Columns[0].Visible = false;
                dgvBuscarDatos.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
            
        }
    }
}
