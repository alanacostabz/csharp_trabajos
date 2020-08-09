using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSabado
{
    public partial class Articulos : Form
    {
        private int siguineteID = 1;
        private int seleccionadID = 0;

        public Articulos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
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

        private void Articulos_Load(object sender, EventArgs e)
        {

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
            if(dgbArticulos.SelectedRows.Count == 1)
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
            //Si es nuevo entonces seleccionadoID == 0   
            if (seleccionadID == 0)//es nuevo
            {
                Object[] renglon =
                 {
                    siguineteID,
                    txtNombre.Text,
                    txtExistencia.Value,
                    cbDepartamento.SelectedItem,
                    txtPrecio.Text};

                dgbArticulos.Rows.Add(renglon);
                siguineteID++;
            }
            else //es editadi
            {
                DataGridViewRow miRenglon = dgbArticulos.SelectedRows[0];
                dgbArticulos.SelectedRows[0].Cells["ArtNombre"].Value = txtNombre.Text;
                dgbArticulos.SelectedRows[0].Cells["ArtEXistencia"].Value = txtExistencia.Text;
                dgbArticulos.SelectedRows[0].Cells["ArtDepartamento"].Value = cbDepartamento.SelectedItem;
                dgbArticulos.SelectedRows[0].Cells["ArtPrecio"].Value = txtPrecio.Text;
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

        private void dgbArticulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void llenaDatosDesdeDGV()
        {
            if (dgbArticulos.SelectedRows.Count == 1)
            {
                DataGridViewRow miRenglon = dgbArticulos.SelectedRows[0];
                seleccionadID = (int)miRenglon.Cells["ArtID"].Value;
                txtNombre.Text = miRenglon.Cells["ArtNombre"].Value.ToString();
                txtExistencia.Value = (decimal)miRenglon.Cells["ArtExistencia"].Value;
                cbDepartamento.SelectedItem = miRenglon.Cells["ArtDepartamento"].Value;
                txtPrecio.Text = miRenglon.Cells["ArtPrecio"].Value.ToString();

            }
        }
        private void dgbArticulos_MouseClick(object sender, MouseEventArgs e)
        {

            llenaDatosDesdeDGV();

        }
    }
}
