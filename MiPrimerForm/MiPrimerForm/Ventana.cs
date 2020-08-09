using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerForm
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void llamaVentana_Click(object sender, EventArgs e)
        {
            VentanaSecundaria miVentana = new VentanaSecundaria();

            miVentana.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbItem.SelectedItem.ToString() + "\n" + cbItem.SelectedIndex.ToString() + "\n" + cbItem.SelectedText.ToString());
        }
    }
}
