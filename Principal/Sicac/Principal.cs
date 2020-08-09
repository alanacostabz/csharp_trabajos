using System
    ;
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
    public partial class FormPrinicipal : Form
    {
        Conexion c = new Conexion();
        RegistroAlumnos rg = new RegistroAlumnos();
        RegistroMaestro rm = new RegistroMaestro();
        public FormPrinicipal()
        {
            
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            
            label5.Visible = false;
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private int DllImport(string v, object EntryPoint)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
            label1.Visible = false;
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rg.Show();
            this.Hide();

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

            label2.Visible = false;
        }

        private void PanelPrincipal_MouseHover(object sender, EventArgs e)
        {

        }

        private void PanelPrincipal_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

       
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        

        private void label4_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Materias mt = new Materias();
            mt.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Calificaciones cf = new Calificaciones();
            cf.Hide();
        }
    }
}
