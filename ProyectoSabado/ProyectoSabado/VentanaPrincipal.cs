using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSabado
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llama ventana Créditos copyright, etc;
            AcercaDe aiuda = new AcercaDe();
            aiuda.ShowDialog();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lama ventana Articulos
            Articulos vtnarticulos = new Articulos();
            vtnarticulos.ShowDialog();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoVenta miPV = new PuntoVenta();
        }
    }
}
