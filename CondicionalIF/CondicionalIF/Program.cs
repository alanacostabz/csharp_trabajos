using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            

            if (edad < 18) Console.WriteLine("No puedes conducir vehiculos");
            else
            {
                Console.WriteLine("¿Tienes carnet?");
                String carnet = Console.ReadLine();

                int compara = String.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");
                else Console.WriteLine("Lo siento, no puedes conducir vehiculos");
                
            }
            

            



            
            
            //ctrl+f5 para ejecutar programa
            
            
        }
    }
}
