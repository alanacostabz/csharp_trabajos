using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sicac
{
    public partial class RegistroMaestro : Form
    {
        Conexion c = new Conexion();
        public RegistroMaestro()
        {
            InitializeComponent();
            c.cargarmaestros(dgvMaestros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c.maestroregistrado(Convert.ToInt32(txtid.Text)) == 0)
            {
                MessageBox.Show(c.insertarmaestro(Convert.ToInt32(txtid.Text), txtname.Text, txtmat.Text, txtpat.Text, txtemail.Text));
                c.cargarmaestros(dgvMaestros);
                txtid.Text = "";
                txtname.Text = "";
                txtmat.Text = "";
                txtpat.Text = "";
                txtemail.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea modifcar la informacion?", "¿Estas seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(c.actualizarmaestro(Convert.ToInt32(txtid.Text), txtname.Text, txtpat.Text, txtmat.Text, txtemail.Text));
                c.cargarmaestros(dgvMaestros);
                txtid.Text = "";
                txtname.Text = "";
                txtmat.Text = "";
                txtpat.Text = "";
                txtemail.Text = "";

            }
            else
            {
                MessageBox.Show("No se pudo modificar el registro");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el mensaje?", "¿Estas seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(c.eliminarmaestro(Convert.ToInt32(txtid.Text)));
                c.cargarmaestros(dgvMaestros);

            }
            else
            {
                MessageBox.Show("No se puedo eliminar el registro");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPrinicipal pr = new FormPrinicipal();
            pr.Show();
            this.Hide();
        }
    }
}
