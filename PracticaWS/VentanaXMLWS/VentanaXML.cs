using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaXMLWS
{
    public partial class VentanaXML : Form
    {
        public VentanaXML()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PracticaWS.PracticaWSSoapClient x = new PracticaWS.PracticaWSSoapClient();
            dataGridView1.DataSource = x.LeeXML();
        }
    }
}
