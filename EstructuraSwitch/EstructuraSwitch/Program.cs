using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce número de mes para cálculo de la comisión");

            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                    Console.WriteLine("Mes escogigo: enero");
                    break;
                case 2:
                    Console.WriteLine("Mes escogigo: febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes escogigo: marzo");
                    break;
                case 4:
                    Console.WriteLine("Mes escogigo: abril");
                    break;
                case 5:
                    Console.WriteLine("Mes escogigo: mayo");
                    break;
                case 6:
                    Console.WriteLine("Mes escogigo: junio");
                    break;
                case 7:
                    Console.WriteLine("Mes escogigo: julio");
                    break;
                case 8:
                    Console.WriteLine("Mes escogigo: agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes escogigo: septiembre");
                    break;
                case 10:
                    Console.WriteLine("Mes escogigo: octubre");
                    break;
                case 11:
                    Console.WriteLine("Mes escogigo: noviembre");
                    break;
                case 12:
                    Console.WriteLine("Mes escogigo: diciembre");
                    break;
                default:
                    Console.WriteLine("Mes no valido");
                    break;

            }

           
            Console.WriteLine("Ha terminado el progama");   
            
        }
    }
}
