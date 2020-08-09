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
    public partial class CatalogoArticulos : Form
    {
        private int siguienteID = 1;
        private int selecionadoID = 0;

        public CatalogoArticulos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            selecionadoID = 0;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Enabled = true;
            txtExistencia.Enabled = true;
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
            txtExistencia.Enabled = true;
            cbDepartamento.Enabled = true;
            txtPrecio.Enabled = true;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.SelectedRows.Count == 1)
            {
                llenaDatosDesdeDGV();
            }

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNombre.Enabled = false;
            txtExistencia.Enabled = false;
            cbDepartamento.Enabled = false;
            txtPrecio.Enabled = false;

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Si es NUEVO entonces selecciondoID == 0
            if (selecionadoID == 0) // Es nuevo
            {
                Object[] renglon = {
                                    siguienteID
                                    ,txtNombre.Text
                                    ,txtExistencia.Value
                                    ,cbDepartamento.SelectedItem
                                    ,txtPrecio.Text };
                dgvArticulos.Rows.Add(renglon);
                siguienteID++;
            }
            else // Es editado
            {
                DataGridViewRow miRenglon = dgvArticulos.SelectedRows[0];
                miRenglon.Cells["ArtNombre"].Value = txtNombre.Text;
                miRenglon.Cells["ArtExistencia"].Value = txtExistencia.Value;
                miRenglon.Cells["ArtDepartamento"].Value = cbDepartamento.SelectedItem;
                miRenglon.Cells["ArtPrecio"].Value = txtPrecio.Text;
            }
            
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNombre.Enabled = false;
            txtExistencia.Enabled = false;
            cbDepartamento.Enabled = false;
            txtPrecio.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void llenaDatosDesdeDGV()
        {
            if (dgvArticulos.SelectedRows.Count == 1)
            {
                DataGridViewRow miRenglon = dgvArticulos.SelectedRows[0];
                selecionadoID = (int)miRenglon.Cells["ArtID"].Value;
                txtNombre.Text = miRenglon.Cells["ArtNombre"].Value.ToString();
                txtExistencia.Value = (decimal)miRenglon.Cells["ArtExistencia"].Value;
                txtPrecio.Text = miRenglon.Cells["ArtPrecio"].Value.ToString();
                cbDepartamento.SelectedItem = miRenglon.Cells["ArtDepartamento"].Value.ToString();
            }
        }
        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            llenaDatosDesdeDGV();
        }
    }
}
