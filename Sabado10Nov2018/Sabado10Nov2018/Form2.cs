using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabado10Nov2018
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AU9UD4C\\SQLEXPRESS;Initial Catalog=PVI;Integrated Security=True");
            try
            {
                //Conexión a la BD

                SqlCommand comand = new SqlCommand(); //comandos
                SqlDataReader reader; //obtener información

                comand.CommandText = txtSQL.Text;
                comand.CommandType = CommandType.Text;
                comand.Connection = conn;

                conn.Open(); //abre la conexión
                reader = comand.ExecuteReader(); //obtener informaciónn

                DataTable dt = new DataTable();//llena el reader con el comando a la BD
                dt.Load(reader); //cargar el datatable con el reader
                dataGridView1.DataSource = dt; //ligarlo al dgv


            }
            catch (Exception ex)
            {

                MessageBox.Show("Excepción en base de datos: " + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }

        }
    }
}
