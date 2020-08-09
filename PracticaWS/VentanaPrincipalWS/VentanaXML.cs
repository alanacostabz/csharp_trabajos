using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipalWS
{
    public partial class VentanaXML : Form
    {
        public VentanaXML()
        {
            InitializeComponent();
        }

        private void VentanaXML_Load(object sender, EventArgs e)
        {
            
            prueba.WSXMLSoapClient x = new prueba.WSXMLSoapClient();
            dataGridView1.DataSource = x.LeeXML();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
