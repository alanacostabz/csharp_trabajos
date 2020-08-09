using System;

namespace Practica_Metodos2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(Suma(valor1, valor2, valor3));
            
        }

        private static double Suma(int n1, double n2, double n3=0)
        {
            return n1 + n2 + n3;
        }

        static double Suma(int n1, double n2)
        {
            return n1 + n2;
        }
    }
}
