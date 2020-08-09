using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaVideojuegos
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            llenaCatalogo();
        }

        public void llenaCatalogo()
        {
            dgvCatalogo.Rows.Add(new Object[] {
                "Red dead redemption 2",
                "Acción",
                120,
                5,
                "Playstation 4"
                
            });

            dgvCatalogo.Rows.Add(new Object[] {
                "God of war",
                "Acción",
                120,
                3,
                "Playstation 4"

            });

            dgvCatalogo.Rows.Add(new Object[] {
                "Final Fantasy XV",
                "RPG",
                100,
                7,
                "Playstation 4"

            });

            dgvCatalogo.Rows.Add(new Object[] {
                "Dragon Ball Figtherz",
                "Pelea",
                115,
                10,
                "XBOX ONE X"

            });

            dgvCatalogo.Rows.Add(new Object[] {
                "Ultimate Super Smash Bros",
                "Pelea",
                100,
                2,
                "Nintendo Switch"

            });
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCatalogo.SelectedRows.Count == 1)
                {
                    int existencia = (int)dgvCatalogo.SelectedRows[0].Cells["colExistencia"].Value;
                    if (existencia > 0)
                    {


                        String nombre = dgvCatalogo.SelectedRows[0].Cells["colNombre"].Value.ToString();
                        double precio = Double.Parse(dgvCatalogo.SelectedRows[0].Cells["colPrecio"].Value.ToString());
                        DateTime inicio = DateTime.Now;//new DateTime().ToShortDateString()
                        DateTime fin = DateTime.Now.AddDays(10);
                        String plataforma = dgvCatalogo.SelectedRows[0].Cells["colPlataforma"].Value.ToString();

                        dgvRenta.Rows.Add(

                        new Object[]{
                        nombre, precio, inicio, fin, plataforma
                        });

                        dgvCatalogo.SelectedRows[0].Cells["colExistencia"].Value = (int)dgvCatalogo.SelectedRows[0].Cells["colExistencia"].Value - 1;

                    }
                }
                else
                {
                    MessageBox.Show("No hay existencias  de este videojuego");
                }
                else
                {
                    MessageBox.Show("Solo se puede seleccionar un renglon del catálogo");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Excepción: " + ex.ToString());
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRenta.SelectedRows.Count >= 1)

                {
                    foreach (DataGridViewRow renglon in dgvRenta.SelectedRows)
                    {
                        int indice = renglon.Index;
                        String nombre = renglon.Cells["rentaNombre"].Value.ToString();
                        String plataforma = renglon.Cells["rentaPlataforma"].Value.ToString();

                        dgvRenta.Rows.RemoveAt(indice);

                        foreach (DataGridViewRow rCatalogo in dgvCatalogo.Rows)
                        {
                            String nombreCatalogo = rCatalogo.Cells["colNombre"].Value.ToString();
                            String plataformaCatalogo = rCatalogo.Cells["colPlataforma"].Value.ToString();
                            if (nombreCatalogo.Equals(nombre) && plataformaCatalogo.Equals(plataforma))
                            {
                                rCatalogo.Cells["colExistencia"].Value = (int)rCatalogo.Cells["colExistencia"].Value + 1;
                                break;
                            }
                            

                            
                        }
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Excepción: " + ex.ToString());
            }
        }

        private void DgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
