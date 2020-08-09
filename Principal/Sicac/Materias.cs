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
    public partial class Materias : Form
    {
        Conexion c = new Conexion();
        public Materias()
        {
             InitializeComponent();
            c.llenarmaterias(cmm);
            c.cargarmaterias(dgvmat);
        }
     
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (c.alumnoregistrado(Convert.ToInt32(ID.Text)) == 0)
            {
                MessageBox.Show(c.insertarmateria(Convert.ToInt32(ID.Text), Materia.Text, cmm.SelectedText.ToString()));
                c.cargarmaterias(dgvmat);
                ID.Text = "";
                Materia.Text = "";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPrinicipal pr = new FormPrinicipal();
            pr.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Materia_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
