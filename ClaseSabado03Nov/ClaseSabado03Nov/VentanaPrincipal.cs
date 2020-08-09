using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseSabado03Nov
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llama ventana Créditos, copyrigth, etc
            AcercaDe misCreditos = new AcercaDe();
            misCreditos.ShowDialog();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoArticulos ventana = new CatalogoArticulos();
            ventana.ShowDialog();
        }

        private void leeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoMusica miMusica = new CatalogoMusica();
            miMusica.ShowDialog();
        }

        private void puntoDeVentaPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoVenta miPV = new PuntoVenta();
            miPV.ShowDialog();
        }
    }
}
