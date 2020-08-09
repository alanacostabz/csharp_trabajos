using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrePractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            obtenComputadoras();
        }
        private void obtenComputadoras()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("E:\\PVI\\Musica.xml");
            dgvCatalogo.DataSource = ds.Tables[0];
            dgvCatalogo.Columns[dgvCatalogo.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCatalogo.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dgvCatalogo.SelectedRows[0];
                    double precio = Double.Parse(row.Cells["Precio"].Value.ToString());
                    decimal cantidad = numCantidad.Value;

                    Object[] renglon =
                    {
                        row.Cells["Marca"].Value.ToString(),
                        row.Cells["Modelo"].Value.ToString(),
                        cantidad,
                        precio,
                        (precio *(double) cantidad)
                    };
                    dgvVenta.Rows.Add(renglon);
                } else
                {
                    MessageBox.Show("Selecciona un renglon, y solo 1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion: " + ex);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count >= 1)
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
    }
}