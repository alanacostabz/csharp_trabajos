using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Sabado
{
    public partial class CatalogoArticulos : Form
    {
        private int siguienteID = 1;
        private int seleccionadoID = 0;
        public CatalogoArticulos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            seleccionadoID = 0;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Enabled = true;
            nudExistencia.Enabled = true;
            cbDepartamento.Enabled = true;
            txtPrecio.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Enabled = true;
            nudExistencia.Enabled = true;
            cbDepartamento.Enabled = true;
            txtPrecio.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;


        }

        public void llenaDatosDesdedgv()
        {
            if (dgvArticulos.SelectedRows.Count == 1)
            {
                DataGridViewRow miRenglon = dgvArticulos.SelectedRows[0];
                seleccionadoID = (int)miRenglon.Cells["artID"].Value;
                txtNombre.Text = miRenglon.Cells["artNombre"].Value.ToString();
                nudExistencia.Value = (decimal)miRenglon.Cells["artExistencia"].Value;
                txtPrecio.Text = miRenglon.Cells["artPrecio"].Value.ToString();
                cbDepartamento.SelectedItem = miRenglon.Cells["artDepartamento"].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count == 1)
            {

                llenaDatosDesdedgv();
            }
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNombre.Enabled = false;
            nudExistencia.Enabled = false;
            cbDepartamento.Enabled = false;
            txtPrecio.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //si es uevo entonces seleccioandoID = 0
            if (seleccionadoID == 0)

            {
                Object[] renglon =
                       {
               siguienteID
                ,txtNombre.Text
                ,nudExistencia.Value
                ,cbDepartamento.SelectedItem
                ,txtPrecio.Text

            };
                dgvArticulos.Rows.Add(renglon);
                siguienteID++;
            }
            else //es editable
            {
                DataGridViewRow miRenglon = dgvArticulos.SelectedRows[0];
                miRenglon.Cells["artNombre"].Value = txtNombre.Text;
                miRenglon.Cells["artExistencia"].Value = nudExistencia.Value;
                miRenglon.Cells["artDepartamento"].Value = cbDepartamento.SelectedItem;
                miRenglon.Cells["artPrecio"].Value = txtPrecio.Text;
            }

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNombre.Enabled = false;
            nudExistencia.Enabled = false;
            cbDepartamento.Enabled = false;
            txtPrecio.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;

        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            llenaDatosDesdedgv();
        }
    }
}
