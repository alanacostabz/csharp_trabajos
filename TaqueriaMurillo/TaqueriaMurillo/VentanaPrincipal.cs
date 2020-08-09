using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaqueriaMurillo
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();

            llenaMenu();
        }

        public void llenaMenu()
        {
            Object[] renglon = {"Taco Asada", 34,
                                "Carne Asada en tortilla de harina" };
            dgvMenu.Rows.Add(renglon);

            renglon[0] = "Caramelo";
            renglon[1] = 37;
            renglon[2] = "Taco de carne asada con queso chihuahua y frijol en tortilla de harina";
            dgvMenu.Rows.Add(renglon);

            dgvMenu.Rows.Add(new Object[] { "Adobada", 30
                                        , "Taco con carne adobada" });

        }

        private void botAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar un renglón seleccionado
                if (dgvMenu.SelectedRows.Count == 1)
                {
                    /*
                    int subtotal = obtieneSubtotal(Int32.Parse(txtCantidad.ToString())
                    , Int32.Parse(dgvMenu.SelectedRows[0].Cells["colPrecio"].Value.ToString()));
                    */
                    // MessageBox.Show("" + dgvMenu.SelectedRows[0].Cells["colPrecio"].Value.ToString())

                    int subtotal = int.Parse(txtCantidad.Text)
                                    *
                                    int.Parse(dgvMenu.SelectedRows[0].Cells["colPrecio"].Value.ToString());
                    Object[] renglonOrden = {
                    dgvMenu.SelectedRows[0].Cells["colNombre"].Value.ToString()
                    , Int32.Parse(txtCantidad.Text)
                    , Int32.Parse(dgvMenu.SelectedRows[0].Cells["colPrecio"].Value.ToString())
                    , subtotal
                    };

                    dgvOrden.Rows.Add(renglonOrden);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.ToString());
            }
        }

        public int obtieneSubtotal(int cantidad, int precio)
        {
            return cantidad * precio;
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvOrden.Rows.Count > 0)
                {
                    //dgvOrden.Rows[0].Cells["OrdenSubtotal"].Value.ToString();
                    double total = 0;
                    foreach (DataGridViewRow renglon in dgvOrden.Rows)
                    {

                        // total += int.Parse(renglon.Cells["OrdenSubtotal"].Value.ToString());
                        total += (int)renglon.Cells["OrdenSubtotal"].Value;
                    }
                    if (rb10.Checked)
                    {
                        total = total * 1.10;
                    }
                    else if (rb15.Checked)
                    {
                        total = total * 1.15;
                        
                    }
                  
                        txtTotal.Text = "" + total;
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Excepción; " + ex.ToString());
            }

        }

        private void rb15_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rb0_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
