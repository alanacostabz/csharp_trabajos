using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Alan Acosta!"); //Esto imprime un mensaje en consola 

            /*int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona4);*/

            /*  var edadPersona2 ="Alan";
              double temp = 30.2;
              int tempHMO;

              //conversión explícita o casting
              tempHMO = (int)temp;

              //conversión implícita
              int habitantesCiudad = 100000;
              long habitantesCiudad2018 = habitantesCiudad;
              float pesoMaterial = 5.78F;
              double pesoMaterialPre = pesoMaterial;

              Console.WriteLine(pesoMaterialPre);*/


            Console.WriteLine("Introduce el primer número: ");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resutlado es " + (num1 + num2));
        }
    }
}
