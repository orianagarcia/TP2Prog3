using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominios;
using Negocio;

namespace PROG3_TP2_Gaarcia_Oriana
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_listados_Click(object sender, EventArgs e)
        {

        }

        private void Item_agregar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.ShowDialog();
            
        }

        private void PORPRECIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListado();
            formulario.ShowDialog();

        }

        private void Item_modificar_Click(object sender, EventArgs e)
        {
            Form formulario = new frmModificar();
            formulario.ShowDialog();
        }

        private void PORCODIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new buscar();
            formulario.ShowDialog(); 
        }

        private void Item_eliminar_Click(object sender, EventArgs e)
        {
            Form formulario = new frmEliminar();
            formulario.ShowDialog();
        }
    }
}


