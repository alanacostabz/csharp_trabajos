using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            StreamReader objReader = new StreamReader("C:\\Users\\bryan\\Documents\\sub.txt");
            string sLine = "";
            ArrayList texto = new ArrayList();
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    texto.Add(sLine);
            }
            foreach(string i in texto){
                textBox1.AppendText(i);
            }
        }
    }
}
