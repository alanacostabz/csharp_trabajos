using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseSabado03Nov
{
    public partial class CatalogoMusica : Form
    {
        public CatalogoMusica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("E:\\PVI\\Musica.xml");

            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
