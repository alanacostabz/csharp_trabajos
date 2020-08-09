using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int nGenerado = n.Next(0, 100);
            int respuesta;
            int intentos = 0;

            Console.WriteLine("Introduce un numero del 0 al 100");
            do
            {
                intentos++;
                try
                {
                    respuesta = Int32.Parse(Console.ReadLine());
                }

           

                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error");
                   // Console.WriteLine(ex.Message);
                    respuesta = 0;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("has inotroducido texto");
                    respuesta = 0;
                }






                if (respuesta > nGenerado)
                {
                    Console.WriteLine($"El número generado es menor a {respuesta}");

                    
                }
                else if (respuesta < nGenerado)
                {
                    Console.WriteLine($"El número generado es mayor a {respuesta}");
                    
                }
                else
                {
                    Console.WriteLine($"Correcto!!! el número generado es {respuesta}");
                    
                }


            } while (respuesta != nGenerado);

            Console.WriteLine($"Has salido del bucle... el número generado es {respuesta}, solo tardaste {intentos} intentos");
            Console.WriteLine("A partir de esta línea el código conitunaría");
        }
    }


}


