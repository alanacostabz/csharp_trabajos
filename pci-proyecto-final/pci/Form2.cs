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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void graficar(double reorden, double cantidadOptima, double tiempoEntrega,double demanda)
        {
            int x = 1;
            int first = 0;
            double inventario = reorden + cantidadOptima;
            double inventarioreal = reorden;
            chart1.Series["Series1"].Points.AddXY(0, inventario);
            chart1.Series["Series2"].Points.AddXY(0, reorden);
            for (var j = 0; j <= 3; j++)
            {

                var y = inventario;
                int val = 0;
                while (y > reorden)
                {
                    if (first == 1)
                    {
                        if (val <=tiempoEntrega)
                            chart1.Series["Series3"].Points.AddXY(x - 1, inventarioreal);
                       

                        inventarioreal -= demanda;

                    }

                    y -= demanda;

                    chart1.Series["Series1"].Points.AddXY(x, y);
                    x++;
                    val++;
                    if (val >tiempoEntrega-1)
                    {
                        inventarioreal = y+demanda;
                        chart1.Series["Series3"].Points.AddXY(x - 2, inventarioreal);
                        inventarioreal -= demanda;
                    }
                        

                    if (!(y > reorden))
                    {

                        chart1.Series["Series1"].Points.AddXY(x - 1, inventario);
                        first = 1;
                        val = 0;
                    }
                }
            }
            chart1.Series["Series2"].Points.AddXY(x, reorden);
        }
    }
}
