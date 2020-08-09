using System;


namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int nGenerado = n.Next(1, 100);
            int respuesta = 0;
            int intentos = 0;

       
            while (respuesta != nGenerado)
            {
                Console.WriteLine("Introduce un numero del 1 al 100");

                respuesta = Int32.Parse(Console.ReadLine());

                if(respuesta > nGenerado)
                {
                    Console.WriteLine($"El número generado es menor a {respuesta}");
                    intentos++;
                } else if(respuesta < nGenerado)
                {
                    Console.WriteLine($"El número generado es mayor a {respuesta}");
                    intentos++;
                } else
                {
                    Console.WriteLine($"Correcto!!! el número generado es {respuesta}");
                    intentos++;
                }

              
            }
           
            Console.WriteLine($"Has salido del bucle... el número generado es {respuesta}, solo tardaste {intentos} intentos");
        }
    }
}
