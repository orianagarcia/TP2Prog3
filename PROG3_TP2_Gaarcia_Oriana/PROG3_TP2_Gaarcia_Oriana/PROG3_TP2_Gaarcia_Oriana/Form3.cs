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
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }
        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                dgvListadoArticulos.DataSource = negocio.Listar();
                dgvListadoArticulos.Columns[0].Visible = false;
                dgvListadoArticulos.Columns[4].Visible = false;
                dgvListadoArticulos.Columns[8].Visible = false; 
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmListado_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
