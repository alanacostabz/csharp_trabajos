using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pci
{
    public partial class Form1 : Form
    {
        double _demanda = 0;
        double _costoColocarOrden = 0;
        double _cargoMantenerUnidadDinero = 0;
        double _cargoMantenerUnidadPorcentaje = 0;
        double _tiempoEntrega = 0;
        double _desviacionEstandar = 0;
        double _valorZ = 0;
        double _desvEstTiempo = 0;
        double _puntoReorden = 0;
        double _inventarioSeguridad = 0;
        double d = 0;
        double ic = 0;
        double q = 0;


        public Form1()
        {
            InitializeComponent();
            diasLaboralesAnio.Enabled = true;
            semanasLaboralesAnio.Enabled = false;
            mesesLaboralesAnio.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Demanda_TextChanged(object sender, EventArgs e)
        {

        }

        private void Demanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void CargoMantenerUnidadDinero_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargoMantenerUnidadDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(cargoMantenerUnidadDinero.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma)))
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void CostoColocarOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(cargoMantenerUnidadDinero.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma)))
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void DesvEstandar_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesvEstandar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(cargoMantenerUnidadDinero.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma)))
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void TiempoEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void CargoMantenerUnidadPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void NivelServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(cargoMantenerUnidadDinero.TextLength >= 0 && (e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Oemcomma)))
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                // only allow one decimal point
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }

                if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
          
             if( nivelServicio.Text =="")
            {
                MessageBox.Show("Asegurse de llenar el campo del valor Z");
            }
            // else if (Convert.ToDouble(cargoMantenerUnidadPorcentaje.Text) < 0 || Convert.ToDouble(cargoMantenerUnidadPorcentaje.Text) > 100)
            //{
            //    MessageBox.Show("Los rangos de porcentajes deben de tener un rango entre 0 y 100");
            //}
            
            else
            {
               //_demanda = Convert.ToInt32(demanda.Text);
               //_costoColocarOrden = Convert.ToDouble(costoColocarOrden.Text);
               //_cargoMantenerUnidadDinero = Convert.ToDouble(cargoMantenerUnidadDinero.Text);
               //_cargoMantenerUnidadPorcentaje = Convert.ToDouble(cargoMantenerUnidadPorcentaje.Text);
               //_tiempoEntrega = Convert.ToDouble(tiempoEntrega.Text);
               //_desviacionEstandar = Convert.ToDouble(desvEstandar.Text);
               _valorZ = Convert.ToDouble(nivelServicio.Text);
                if (tiempoEntrega.Text != "") { _tiempoEntrega = Convert.ToDouble(tiempoEntrega.Text); }
                if (cargoMantenerUnidadPorcentaje.Text != "") { _cargoMantenerUnidadPorcentaje = Convert.ToDouble(cargoMantenerUnidadPorcentaje.Text); }
                if (cargoMantenerUnidadDinero.Text != "") { _cargoMantenerUnidadDinero = Convert.ToDouble(cargoMantenerUnidadDinero.Text); }
                if (costoColocarOrden.Text != "") { _costoColocarOrden = Convert.ToDouble(costoColocarOrden.Text); }
                if (demanda.Text != "") { _demanda = Convert.ToDouble(demanda.Text); }
                if (desvEstandar.Text != "") { _desviacionEstandar = Convert.ToDouble(desvEstandar.Text); }
                if (desvEstTiempo.Text != "") { _desvEstTiempo = Convert.ToDouble(desvEstTiempo.Text); }

               

                double respuesta1 = cantidadOptimaOrdenar(_costoColocarOrden, _demanda, _cargoMantenerUnidadPorcentaje, _cargoMantenerUnidadDinero);
                //double respuesta2 = demandaPromedioTiempoEntrega(_tiempoEntrega, _demanda);
                //double respuesta3 = desvEstandarTiempoEntrega(_tiempoEntrega, _desviacionEstandar);
                double respuesta4 = inventarioSeguridad(_valorZ, _desviacionEstandar, _tiempoEntrega,_desvEstTiempo, _demanda, _desviacionEstandar);
                double respuesta5 = puntoReorden(_demanda, _desviacionEstandar, _valorZ, _tiempoEntrega, _desvEstTiempo,_desvEstTiempo);
                double respuesta6 = costoAnualInventario(_inventarioSeguridad, d, ic, _costoColocarOrden, q);



                cantidadOptima.Text = "" + respuesta1 + " Unidades";
                //demandaPromedio.Text = "" + respuesta2 + " Unidades";
                //DETiempoEntrega.Text = "" + respuesta3 + " Unidades";
                inventarioSS.Text = "" + respuesta4 + " Unidades";
                rhPunto.Text = "" + respuesta5 + " Unidades";
                costoTotalInventario.Text = "$ " + respuesta6;
       


            }
        }


        ///////////////////////////// Métodos  //////////////////////////////////
        public double cantidadOptimaOrdenar(double costoColocarOrden, double demanda, double cargoMantenerUnidadPorcentaje, double costoMantenerUnidadDinero)
        {
            
            
            

            if (cargoMantenerUnidadPorcentaje != 0)
            {
                ic = costoMantenerUnidadDinero * (cargoMantenerUnidadPorcentaje / 100);
            } else
            {
                ic = costoMantenerUnidadDinero;
            }

            if (rbDias.Checked)
            {
                d = (diasLaboralesAnio.Text == "0" || diasLaboralesAnio.Text == "") ? 365 * demanda : Convert.ToDouble(diasLaboralesAnio.Text) * demanda;
                
            }
            else if (rbSemana.Checked)
            {
                d = (semanasLaboralesAnio.Text == "0" || semanasLaboralesAnio.Text == "") ? 52 * demanda : Convert.ToDouble(semanasLaboralesAnio.Text) * demanda;
               
            }
            else if (rbMes.Checked)
            {
                d = (mesesLaboralesAnio.Text == "0" || mesesLaboralesAnio.Text == "") ? 52 * demanda : Convert.ToDouble(mesesLaboralesAnio.Text) * demanda;
            
            } else
            {
                d = demanda;
               
            }

            
            q = Math.Round(Math.Sqrt((2 * costoColocarOrden * d) / ic), 0); 

            if (Double.IsNaN(q))
            {
                return 0;
            } else
            {
                return q;
            }


        }

        //public double demandaPromedioTiempoEntrega(double tiempoEntrega, double demanda)
        //{ 
        //       return demanda * tiempoEntrega;
        //}

        //public double desvEstandarTiempoEntrega(double tEntrega, double desviacionEstandar)
        //{
        //        return Math.Round(Math.Sqrt(tEntrega) * desviacionEstandar,0);


        //}

        public double inventarioSeguridad(double valorZ, double desvEst, double tEntrega, double desvEstT, double demanda, double demandaEst)
        {
            //return Math.Round(valorZ * demandaEstandarTiempoEntrega,0);
            if (op1.Checked)
            {
                _inventarioSeguridad = Math.Round(valorZ * (desvEst) * Math.Sqrt(tEntrega));
            }
            else if (op2.Checked)
            {
                _inventarioSeguridad =  Math.Round(valorZ * (desvEstT) * demanda);
            }
            else if (op3.Checked)
            {
                _inventarioSeguridad =  Math.Round(valorZ * Math.Sqrt((demandaEst * demandaEst) * tEntrega + (demanda * demanda) * (desvEstT * desvEstT)));
            }
            else
            {
                _inventarioSeguridad = 0;
            }
            return _inventarioSeguridad;
        }

        public double puntoReorden(double demanda, double desvEst, double valorZ, double tEntrega, double desvEstT, double demandaEst)
        {
            //return Math.Round(demandaPromedioTiempoEntrega + (valorZ*desvEstandarTiempoEntrega), 0);
            if (op1.Checked)
            {
                _puntoReorden = Math.Round(demanda * (tEntrega) + valorZ * (desvEst) * Math.Sqrt(tEntrega));
                
            } else if (op2.Checked)
            {
                _puntoReorden =  Math.Round(demanda * tEntrega + valorZ * desvEstT * demanda);
            } else if (op3.Checked)
            {
                _puntoReorden = Math.Round((demanda * tEntrega) + valorZ * Math.Sqrt((demandaEst * demandaEst) * tEntrega + (demanda * demanda) * (desvEstT * desvEstT)));
            }
            else
            {
                _puntoReorden = 0;
            }

            return _puntoReorden;
        }

        public double costoAnualInventario(double inventarioSeguridad, double d, double ic, double a, double q)
        {
            double costoAnual = Math.Round((q / 2 * ic) + (d / q * a) + ic * inventarioSeguridad,2);
            if (Double.IsNaN(costoAnual))
            {
                return costoAnual = 0;
            } else
            {
                return costoAnual;
            }
        }
        

        /////////////////////////////////////////////////
        private void Aggh_Click(object sender, EventArgs e)
        {

        }

        private void DiasLaboralesAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            cantidadOptima.Text = "";
            //demandaPromedio.Text = "";
            //DETiempoEntrega.Text = "";
            inventarioSS.Text = "";
            costoTotalInventario.Text = "";
            desvEstTiempo.Text = "";
            rhPunto.Text = "";
            demanda.Text = "";
            tiempoEntrega.Text = "";
            desvEstandar.Text = "";
            costoColocarOrden.Text = "";
            cargoMantenerUnidadDinero.Text = "";
            cargoMantenerUnidadPorcentaje.Text = "";
            nivelServicio.Text = "";
            diasLaboralesAnio.Text = "";
            semanasLaboralesAnio.Text = "";
            mesesLaboralesAnio.Text = "";
        }

        private void Label22_Enter(object sender, EventArgs e)
        {

        }

        private void RbMes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMes.Checked)
            {
                diasLaboralesAnio.Enabled = false;
                semanasLaboralesAnio.Enabled = false;
                mesesLaboralesAnio.Enabled = true;
                semanasLaboralesAnio.Text = "";
                diasLaboralesAnio.Text = "";


            }
        }

        private void OpcionUnidades_Enter(object sender, EventArgs e)
        {

        }

        private void RbDias_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDias.Checked)
            {
                diasLaboralesAnio.Enabled = true;
                semanasLaboralesAnio.Enabled = false;
                mesesLaboralesAnio.Enabled = false;
                semanasLaboralesAnio.Text = "";
                mesesLaboralesAnio.Text = "";


            }
           
        }

        private void RbSemana_CheckedChanged(object sender, EventArgs e)
        {
             if (rbSemana.Checked)
            {
                diasLaboralesAnio.Enabled = false;
                semanasLaboralesAnio.Enabled = true;
                mesesLaboralesAnio.Enabled = false;
                diasLaboralesAnio.Text = "";
                mesesLaboralesAnio.Text = "";

            }
        }

        private void RbAnio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAnio.Checked)
            {
                diasLaboralesAnio.Enabled = false;
                semanasLaboralesAnio.Enabled = false;
                mesesLaboralesAnio.Enabled = false;
                diasLaboralesAnio.Text = "";
                semanasLaboralesAnio.Text = "";
                mesesLaboralesAnio.Text = "";
            }
        }

        private void GroupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Op2_CheckedChanged(object sender, EventArgs e)
        {
            if(op2.Checked)
            {
                desvEstTiempo.Enabled = true;
                desvEstandar.Enabled = false;
                desvEstandar.Text = "";
            }
        }

        private void Op1_CheckedChanged(object sender, EventArgs e)
        {
            desvEstTiempo.Enabled = false;
            desvEstandar.Enabled = true;
            desvEstTiempo.Text = "";
        }

        private void Op3_CheckedChanged(object sender, EventArgs e)
        {
            desvEstTiempo.Enabled = true;
            desvEstandar.Enabled = true;
        }
    }
}
