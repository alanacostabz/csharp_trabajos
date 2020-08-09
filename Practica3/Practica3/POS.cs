using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\Users\\bryan\\Documents\\Computadoras.xml");
            dgvComputadoras.DataSource = ds.Tables[0];
            dgvComputadoras.Columns[dgvComputadoras.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            inicializaComponentes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            try
            {
                double descuento = 0;
                if (cbDescuento != null)
                {
                    String des = cbDescuento.SelectedItem.ToString();


                   
                    if (des.Equals("5%"))
                    {
                       
                       descuento = 0.05;
                    } else if (des.Equals("10%"))
                    {
                        descuento = 0.1;
                    }
                    else if (des.Equals("15%"))
                    {
                        descuento = 0.15;
                    }
                    else if (des.Equals("20%"))
                    {
                        descuento = 0.2;
                    }
                    else
                    {
                        descuento = 0;
                    }



                }
                if (dgvComputadoras.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dgvComputadoras.SelectedRows[0];
                    double precio = Double.Parse(row.Cells["Precio"].Value.ToString());
                    double s = precio*descuento;
                    precio = precio - s;
                    decimal cantidad = nupCantidad.Value;

                    object[] renglon =
                    {
                    row.Cells["Marca"].Value.ToString(),
                    row.Cells["Modelo"].Value.ToString(),
                    cantidad,
                    precio,
                    (precio*(double) cantidad)
                };
                    dgvVentas.Rows.Add(renglon);

                   
                    if (dgvVentas.Rows.Count > 0)
                    {
                        double t = 0;
                        foreach (DataGridViewRow item in dgvVentas.Rows)
                        {
                            t += (double)item.Cells["coSubtotal"].Value;
                        }

                        txtIVA.Text = "16%";
                        double total = t * 0.16;
                        txtSubtotal.Text = "" + Math.Round(t,2);
                        Double totalPOS = t + total;
                        Math.Round(totalPOS, 2);
                        txtTotal.Text = "" + Math.Round(totalPOS, 2); ;

                    }


                } else
                {
                    MessageBox.Show("Selecciona un renglon, y solo uno");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Excepción" + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVentas.SelectedRows.Count >= 1)
                {
                    foreach (DataGridViewRow item in dgvVentas.SelectedRows)
                    {
                        dgvVentas.Rows.RemoveAt(item.Index);
                    }
                    if (dgvVentas.Rows.Count > 0)
                    {
                        double t = 0;
                        foreach (DataGridViewRow item in dgvVentas.Rows)
                        {
                            t += (double)item.Cells["coSubtotal"].Value;
                        }

                        txtIVA.Text = "16%";
                        double total = t * 0.16;
                        txtSubtotal.Text = "" + t;
                        txtTotal.Text = "" + (t + total);

                    }
                }
                else
                {
                    inicializaComponentes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción" + ex);
            }
        }

        public void inicializaComponentes()
        {
            txtIVA.Text = "16%";
            txtSubtotal.Text = "0.00";
            txtTotal.Text = "0.00";
            nupCantidad.Value = 1;
            cbDescuento.Text = "0%";
            nupCantidad.Value = 1;
            cbDescuento.Text = "0%";
        }


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {

                /*   foreach (DataGridViewRow item in dgvVentas.Rows)
                   {
                       dgvVentas.Rows.RemoveAt(item.Index);
                   }*/

                dgvVentas.Rows.Clear();


                inicializaComponentes();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción" + ex);
            }
        }
    }
}
