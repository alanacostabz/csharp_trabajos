using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Sabado
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe misDerechos = new AcercaDe();
            misDerechos.ShowDialog();
            
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoArticulos art = new CatalogoArticulos();
            art.ShowDialog();
        }
    }
}
