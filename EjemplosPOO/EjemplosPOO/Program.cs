using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Circulo miCirculo; //creacion de objeto de tipo circulo, variable/objeto de tipo circulo
             miCirculo = new Circulo(); //iniciacion de variable objeto de tipo circulo, instanciar una clase
             //instanciacion, ejemplariazacion, creacion de ejemplar de clase

             Console.WriteLine(miCirculo.CalculoArea(5));

             Circulo miCirculo2 = new Circulo();

             Console.WriteLine(miCirculo2.CalculoArea(9));*/

            ConversorEuroDolar obj = new ConversorEuroDolar();
            obj.CambiaValorEuro(1.45);

            
            Console.WriteLine(obj.Convierte(5));

         
       



        }
    }

    class Circulo
    {
       private const double pi = 3.1416; // propiedad de la clase circulo, campos de clase

        public double CalculoArea(int radio) //método de clase, ¿que pueden hacer los objetos de tipo circulo?
        {
            return pi * radio * radio;
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void CambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0)
            {
                euro = 1.253;
            }
            else
            {
                euro = nuevoValor;
            }
        }
    }
}
