using System;

namespace Practica_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("El resultado de la división es " + divideNumeros(2, 8));
           
        }

        /* static void sumaNumeros(int n1, int n2)
         {
            Console.WriteLine($"El resultado de la suma es: {n1 + n2}");
         }*/
        /* static double divideNumeros(double n1, int n2)
         {

                double resultado = n1/n2;

             return resultado;
         }*/
        static double divideNumeros(double n1, int n2) => n1 / n2;
    }
}
