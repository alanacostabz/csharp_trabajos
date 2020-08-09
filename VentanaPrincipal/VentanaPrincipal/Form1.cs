using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //cbCampus.SelectedItem = "Hermosillo";
            // cbCampus.SelectedItem = "Hermosillo";
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            clbDocumentos.Visible = true;
            cbCampus.Visible = true;
            calendario.Visible = true;
            cbMasculino.Enabled = true;
            cbFemenino.Enabled = true;

            // MessageBox.Show("" + cbMasculino.Enabled);
        }

        private void cbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFemenino.Checked) cbMasculino.Checked = false;

            else cbMasculino.Checked = true;


        }

        private void cbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMasculino.Checked) cbFemenino.Checked = false;

            else cbFemenino.Checked = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show ( 
                "Campus: " + cbCampus.SelectedItem +
                    "Día: " + calendario.SelectionRange.Start.ToShortDateString()
            );
        }
    }
}
