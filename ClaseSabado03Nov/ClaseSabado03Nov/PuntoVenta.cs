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
    public partial class PuntoVenta : Form
    {
        public PuntoVenta()
        {
            InitializeComponent();
            obtenMusicaXML();
        }

        private void obtenMusicaXML()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("E:\\PVI\\Musica.xml");
            // ds.ReadXml(@"C:\PVeI 2018\Musica.xml");

            dgvMusica.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvMusica.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dgvMusica.SelectedRows[0];
                    double precio = Double.Parse(row.Cells["PRICE"].Value.ToString());
                    decimal cantidad = txtCantidad.Value;

                    Object[] renglon =
                    {
                        row.Cells["TITLE"].Value.ToString()
                        ,row.Cells["ARTIST"].Value.ToString()
                        , precio
                        , cantidad
                        , (precio * (double) cantidad)
                    };
                    dgvVenta.Rows.Add(renglon);
                } else
                {
                    MessageBox.Show("Debe seleccionar 1 y solo 1 registro a agregar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgvVenta.SelectedRows.Count >= 1)
            {
                // dgvVenta.Rows.RemoveAt(dgvVenta.SelectedRows[0].Index);
                foreach (DataGridViewRow item in dgvVenta.SelectedRows)
                {
                    dgvVenta.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar 1 y solo 1 registro a eliminar.");
            } 

        }

        private void dgvMusica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PuntoVenta_Load(object sender, EventArgs e)
        {

        }

       
    }
}
