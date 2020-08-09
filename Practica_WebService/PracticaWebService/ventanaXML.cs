using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWebService
{
    public partial class ventanaXML : Form
    {
        public ventanaXML()
        {
            InitializeComponent();
        }

        private void ventanaXML_Load(object sender, EventArgs e)
        {

            w.PracticaWebServiceSoapClient x = new w.PracticaWebServiceSoapClient();
            dataGridView1.DataSource = x.LeeXML();
        }
    }
}
