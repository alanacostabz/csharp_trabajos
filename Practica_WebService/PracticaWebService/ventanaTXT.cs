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
    public partial class ventanaTXT : Form
    {
        public ventanaTXT()
        {
            InitializeComponent();
        }

        private void ventanaTXT_Load(object sender, EventArgs e)
        {
            w.PracticaWebServiceSoapClient x = new w.PracticaWebServiceSoapClient();
           
          
            ArrayList texto = ArrayList.Adapter(x.LeeTXT());
            
            foreach (String i in texto)
             {
                 textBox1.AppendText(i);
             }
        }
    }
}
