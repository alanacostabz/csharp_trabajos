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
    public partial class Calificaciones : Form
    {
        Conexion c = new Conexion();
        public Calificaciones()
        {
            InitializeComponent();
            c.llenarmaestro(cmm);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormPrinicipal pr = new FormPrinicipal();
            pr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!expediente.Equals(""))
            {
                double ta1 = Double.Parse(t1.Text);
                double ta2 = Double.Parse(t2.Text);
                double ta3 = Double.Parse(t3.Text);
                double ta4 = Double.Parse(t4.Text);

                double ex1 = Double.Parse(e1.Text);
                double ex2 = Double.Parse(e2.Text);
                double ex3 = Double.Parse(e3.Text);

                double califTareas = ((ta1 + ta2 + ta3 + ta4) / 4) * 0.40;
                double califExamen = ((ta1 + ta2 + ta3 + ta4) / 3) * 0.60;
                double califTotal = califExamen + califTareas;
            }
        }

        private void cmm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
