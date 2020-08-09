using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaqueriaAcosta
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
            Object[] renglon = {"Taco Asada", 24, "Taco con tortilla de harina y carne asada"};
            dgvMenu.Rows.Add(renglon);
            renglon[0] = "Caramelo";
            renglon[1] = 37;
            renglon[2] = "Taco de carne asada con queso y frijol en torilla de harina";

            dgvMenu.Rows.Add(renglon);

            dgvMenu.Rows.Add(new Object []{ "Adobada", 30, "Taco con carne adobada" });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //Validar un renglon seleccionado
            if (dgvMenu.SelectedRows.Count == 1)
            {
                int subTotal = obtieneSubtotal(Int32.Parse(txtCantidad.Text), Int32.Parse(dgvMenu.SelectedRows[0].Cells["Precio"].Value.ToString()));
                    Object[] renglonOrden = {
                    dgvMenu.SelectedRows[0].Cells["colNombre"].Value.ToString(),
                    Int32.Parse(txtCantidad.Text),
                    Int32.Parse(dgvMenu.SelectedRows[0].Cells["colPrecio"].Value.ToString()),
                    subTotal
                };
                dgvOrden.Rows.Add(renglonOrden);
            }
                
            }
        

        public int obtieneSubtotal(int cantidad, int precio)
        {
            return cantidad * precio;
        }
    }
}
